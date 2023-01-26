
/**
* ---------------------------------------
* This demo was created using amCharts 5.
*
* For more information visit:
* https://www.amcharts.com/
*
* Documentation is available at:
* https://www.amcharts.com/docs/v5/
* ---------------------------------------
*/

// Create root element
// https://www.amcharts.com/docs/v5/getting-started/#Root_element
var root = am5.Root.new("chartdiv");

// Set themes
// https://www.amcharts.com/docs/v5/concepts/themes/
root.setThemes([
    am5themes_Animated.new(root)
]);

var data = { "name": "root", "value": 0, "children": [{ "name": "firstuser", "value": 4, "children": [{ "name": "seconduser", "value": 0, "children": [] }, { "name": "thirduser", "value": 1, "children": [{ "name": "fivthuser", "value": 0, "children": [] }, { "name": "sixthuser", "value": 0, "children": [] }] }, { "name": "fourthuser", "value": 0, "children": [{ "name": "seventhuser", "value": 0, "children": [] }] }] }] };


// Create wrapper container
var container = root.container.children.push(am5.Container.new(root, {
    width: am5.percent(100),
    height: am5.percent(100),
    layout: root.verticalLayout
}));

// Create series
// https://www.amcharts.com/docs/v5/charts/hierarchy/#Adding
var series = container.children.push(am5hierarchy.ForceDirected.new(root, {
    singleBranchOnly: false,
    downDepth: 2,
    topDepth: 1,
    initialDepth: 1,
    valueField: "value",
    categoryField: "name",
    childDataField: "children",
    idField: "name",
    linkWithField: "linkWith",
    manyBodyStrength: -10,
    centerStrength: 0.8
}));

series.get("colors").setAll({
    step: 2
});

series.links.template.set("strength", 0.5);

series.data.setAll([data]);

series.set("selectedDataItem", series.dataItems[0]);


// Make stuff animate on load
series.appear(1000, 100);

