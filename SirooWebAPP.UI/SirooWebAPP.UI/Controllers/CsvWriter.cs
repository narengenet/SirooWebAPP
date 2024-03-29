﻿using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace SirooWebAPP.UI.Controllers
{
    public class CSVChip
    {
        [Display(Name ="PIN")]
        public string PIN { get; set; }

        [Display(Name ="Serial")]
        public string Serial { get; set; }

    }
    public class CSVChallengeUserData
    {
        [Display(Name = "نام")]
        public string Name { get; set; }
        
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        [Display(Name = "نام پدر")]
        public string FatherName { get; set; }

        [Display(Name = "شماره شناسنامه")]
        public string IdentityId { get; set; }

        [Display(Name = "کد ملی")]
        public string NationalId { get; set; }

        [Display(Name = "تاریخ تولد")]
        public string BirthDate { get; set; }

        [Display(Name ="نام کاربری سیرو")]
        public string Username { get; set; }

        [Display(Name ="موبایل")]
        public string Mobile { get; set; }

        [Display(Name = "وضعیت تاهل")]
        public string IsMarried { get; set; }

        //[Display(Name = "معرف")]
        //public string ParentUsername { get; set; }

        [Display(Name = "تاریخ ثبت")]
        public string Created { get; set; }

        [Display(Name = "نوع چالش")]
        public string ChallengeType { get; set; }


    }
    public class CsvWriter
    {
        private const string DELIMITER = ",";

        public string Write<T>(IList<T> list, bool includeHeader = true)
        {
            StringBuilder sb = new StringBuilder();

            Type type = typeof(T);

            PropertyInfo[] properties = type.GetProperties();

            if (includeHeader)
            {
                sb.AppendLine(this.CreateCsvHeaderLine(properties));
            }

            foreach (var item in list)
            {
                sb.AppendLine(this.CreateCsvLine(item, properties));
            }

            return sb.ToString();
        }

        public string Write<T>(IList<T> list, string fileName, bool includeHeader = true)
        {
            string csv = this.Write(list, includeHeader);

            this.WriteFile(fileName, csv);

            return csv;
        }

        private string CreateCsvHeaderLine(PropertyInfo[] properties)
        {
            List<string> propertyValues = new List<string>();

            foreach (var prop in properties)
            {
                string stringformatString = string.Empty;
                string value = prop.Name;

                var attribute = prop.GetCustomAttribute(typeof(DisplayAttribute));
                if (attribute != null)
                {
                    value = (attribute as DisplayAttribute).Name;
                }

                this.CreateCsvStringItem(propertyValues, value);
            }

            return this.CreateCsvLine(propertyValues);
        }

        private string CreateCsvLine<T>(T item, PropertyInfo[] properties)
        {
            List<string> propertyValues = new List<string>();

            foreach (var prop in properties)
            {
                string stringformatString = string.Empty;
                object value = prop.GetValue(item, null);

                if (prop.PropertyType == typeof(string))
                {
                    this.CreateCsvStringItem(propertyValues, value);
                }
                else if (prop.PropertyType == typeof(string[]))
                {
                    this.CreateCsvStringArrayItem(propertyValues, value);
                }
                else if (prop.PropertyType == typeof(List<string>))
                {
                    this.CreateCsvStringListItem(propertyValues, value);
                }
                else
                {
                    this.CreateCsvItem(propertyValues, value);
                }
            }

            return this.CreateCsvLine(propertyValues);
        }

        private string CreateCsvLine(IList<string> list)
        {
            return string.Join(CsvWriter.DELIMITER, list);
        }

        private void CreateCsvItem(List<string> propertyValues, object value)
        {
            if (value != null)
            {
                propertyValues.Add(value.ToString());
            }
            else
            {
                propertyValues.Add(string.Empty);
            }
        }

        private void CreateCsvStringListItem(List<string> propertyValues, object value)
        {
            string formatString = "\"{0}\"";
            if (value != null)
            {
                value = this.CreateCsvLine((List<string>)value);
                propertyValues.Add(string.Format(formatString, this.ProcessStringEscapeSequence(value)));
            }
            else
            {
                propertyValues.Add(string.Empty);
            }
        }

        private void CreateCsvStringArrayItem(List<string> propertyValues, object value)
        {
            string formatString = "\"{0}\"";
            if (value != null)
            {
                value = this.CreateCsvLine(((string[])value).ToList());
                propertyValues.Add(string.Format(formatString, this.ProcessStringEscapeSequence(value)));
            }
            else
            {
                propertyValues.Add(string.Empty);
            }
        }

        private void CreateCsvStringItem(List<string> propertyValues, object value)
        {
            string formatString = "\"{0}\"";
            if (value != null)
            {
                propertyValues.Add(string.Format(formatString, this.ProcessStringEscapeSequence(value)));
            }
            else
            {
                propertyValues.Add(string.Empty);
            }
        }

        private string ProcessStringEscapeSequence(object value)
        {
            return value.ToString().Replace("\"", "\"\"");
        }

        public bool WriteFile(string fileName, string csv)
        {
            bool fileCreated = false;

            if (!string.IsNullOrWhiteSpace(fileName))
            {
                File.WriteAllText(fileName, csv, Encoding.UTF8);

                fileCreated = true;
            }

            return fileCreated;
        }
    }
}
