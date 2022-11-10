

function read() {
    var transaction = db.transaction(["Posts"]);
    var objectStore = transaction.objectStore("Posts");
    var request = objectStore.get("00-03");

    request.onerror = function (event) {
        alert("Unable to retrieve daa from database!");
    };

    request.onsuccess = function (event) {
        // Do something with the request.result!
        //if (request.result) {
        //    alert("Name: " + request.result.name + ", 
        //             Age: " + request.result.age + ", Email: " + request.result.email);
        //       } else {
        //    alert("Kenny couldn't be found in your database!");
        //}
    };
}

function readAll() {
    var objectStore = db.transaction("Posts").objectStore("Posts");

    var res = new Array();
    objectStore.openCursor().onsuccess = function (event) {
        var cursor = event.target.result;

        if (cursor) {
            //$('#adsTemplate').tmpl(cursor.value).appendTo('#adsContainer');
            res.push(cursor.value);
            cursor.continue();
        } else {
            res = res.sort(compareDates);

            $('#adsTemplate').tmpl(res).appendTo('#adsContainer');
            //observer.observe(document.querySelector(".SirooPost"));
            for (var i in res) {
                observer.observe(document.querySelector('#postobject' + res[i].advertiseID));
            }



            ReadOtherAds();
            //alert("No more entries!");
        }
    };
}

const onIntersection = (entries) => {
    for (const entry of entries) {
        if (entry.isIntersecting) {
            if (!$(entry.target).hasClass('watched')) {
                $(entry.target).addClass('watched');
                var startAttr = $(entry.target).attr('starttime');
                if (typeof startAttr == 'undefined' || startAttr == false) {
                    $(entry.target).attr('starttime', entry.time);
                }
            }

        } else {
            if ($(entry.target).hasClass('watched')) {
                var endAttr = $(entry.target).attr('endtime');
                if (typeof endAttr == 'undefined' || endAttr == false) {
                    watchedTime = entry.time - parseFloat($(entry.target).attr('starttime'));
                    if (watchedTime > 5000) {
                        $(entry.target).attr('endtime', entry.time);

                        var fetchedAttr = $(entry.target).attr('fetched');
                        if (typeof fetchedAttr == 'undefined' || fetchedAttr == false) {
                            let adId = $(entry.target).attr('adid');
                            $.ajax({
                                url: '/viewedPost/' + adId,
                                type: 'GET',
                                success: function (result) {

                                    debugger;
                                    if (result == null) {
                                        $('#postobject' + adId).fadeOut(300, function () { $('#postobject' + adId).remove(); });
                                        removeAds(adId);
                                    } else {
                                        justAddAds(result);
                                        $(entry.target).attr('fetched', 'done');
                                    }

                                },
                            });
                        }









                    } else {
                        $(entry.target).removeClass('watched');
                        $(entry.target).removeAttr('starttime');
                    }

                } else {

                }
            }
        }
    }
};

const observer = new IntersectionObserver(onIntersection);


function ReadOtherAds() {
    let lastAdsDate = localStorage.getItem('last-fetch-date');

    var res = new Array();

    $.ajax({
        url: '/nextads/' + lastAdsDate,
        type: 'GET',
        success: function (result) {
            if (result == "gologin") {
                window.location = "/login/login";
            } else {

                for (var i in result) {
                    res.push(result[i]);
                }
                res = res.sort(compareDates);
                for (var i in res) {
                    addAds(result[i], true);
                }

                $('.threeDotsLoading').hide();
                localStorage.setItem('last-fetch-date', new Date().toJSON());


                var dates = $('.profile-date');
                for (i = 0; i < dates.length; i++) {
                    $(dates[i]).text(jQuery.timeago($(dates[i]).text()));
                }

            }

        },
    });
}

function addAds(ads, mustPrepend = false) {
    debugger;
    var request = db.transaction(["Posts"], "readwrite")
        .objectStore("Posts")
        .put(ads);

    request.onsuccess = function (event) {
        $('.threeDotsLoading').hide();
        if (mustPrepend) {
            $('#adsTemplate').tmpl(ads).prependTo('#adsContainer');
        } else {
            $('#adsTemplate').tmpl(ads).appendTo('#adsContainer');
        }

    };

    request.onerror = function (event) {
        alert("Unable to add data\r\nKenny is aready exist in your database! ");
    }
}
function justAddAds(ads) {
    debugger;
    var request = db.transaction(["Posts"], "readwrite")
        .objectStore("Posts")
        .put(ads);

    request.onsuccess = function (event) {
        debugger;
        fetchedAds = $('#adsTemplate').tmpl(ads);
        $('#postobject' + ads.advertiseID).replaceWith(fetchedAds);
    };

    request.onerror = function (event) {
        alert("Unable to add data\r\nKenny is aready exist in your database! ");
    }
}



function removeAds(id) {
    var request = db.transaction(["Posts"], "readwrite")
        .objectStore("Posts")
        .delete(id);

    request.onsuccess = function (event) {
        //alert("Kenny's entry has been removed from your database.");
    };
    request.onerror = function (event) {
        alert("NOT removed from your web database.");
    };
}

function compareDates(a, b) {
    aDate = new Date(a.creationDate);
    bDate = new Date(b.creationDate);
    if (aDate > bDate) {
        return -1;
    }
    if (aDate < bDate) {
        return 1;
    }
    return 0;
}

////(function () {
////    // check for IndexedDB support
////    if (!window.indexedDB) {
////        console.log(`Your browser doesn't support IndexedDB`);
////        return;
////    }

////    // open the CRM database with the version 1
////    const request = indexedDB.open('Siroo', 1);
////    database;

////    // create the Contacts object store and indexes
////    request.onupgradeneeded = (event) => {
////        let db = event.target.result;

////        // create the Contacts object store 
////        // with auto-increment id
////        let store = db.createObjectStore('Posts', {
////            autoIncrement: true
////        });

////        // create an index on the email property
////        let index = store.createIndex('advertiseID', 'advertiseID', {
////            unique: true
////        });
////    };

////    // handle the error event
////    request.onerror = (event) => {
////        console.error(`Database error: ${event.target.errorCode}`);
////    };

////    // handle the success event
////    request.onsuccess = (event) => {
////        const db = event.target.result;



////        $.ajax({
////            url: '/ads?rnd=' + Math.random(),
////            type: 'GET',
////            success: function (result) {
////                if (result == "gologin") {
////                    window.location = "/login/login";
////                } else {
////                    foreach(item in result){
////                        insertAds(db, item);
////                    }

////                }

////            },
////        });

////        // insert contacts
////        // insertContact(db, {
////        //     email: 'john.doe@outlook.com',
////        //     firstName: 'John',
////        //     lastName: 'Doe'
////        // });

////        // insertContact(db, {
////        //     email: 'jane.doe@gmail.com',
////        //     firstName: 'Jane',
////        //     lastName: 'Doe'
////        // });


////        // get contact by id 1
////        // getContactById(db, 1);


////        // get contact by email
////        // getContactByEmail(db, 'jane.doe@gmail.com');

////        // get all contacts
////        // getAllContacts(db);

////        //deleteContact(db, 1);

////    };

////    function insertAds(db, ads) {
////        // create a new transaction
////        const txn = db.transaction('Posts', 'readwrite');

////        // get the Contacts object store
////        const posts = txn.objectStore('Posts');
////        //
////        let query = posts.put(ads);

////        // handle success case
////        query.onsuccess = function (event) {
////            console.log(event);
////        };

////        // handle the error case
////        query.onerror = function (event) {
////            console.log(event.target.errorCode);
////        }

////        // close the database once the 
////        // transaction completes
////        txn.oncomplete = function () {
////            db.close();
////        };
////    }


////    function getContactById(db, id) {
////        const txn = db.transaction('Contacts', 'readonly');
////        const store = txn.objectStore('Contacts');

////        let query = store.get(id);

////        query.onsuccess = (event) => {
////            if (!event.target.result) {
////                console.log(`The contact with ${id} not found`);
////            } else {
////                console.table(event.target.result);
////            }
////        };

////        query.onerror = (event) => {
////            console.log(event.target.errorCode);
////        }

////        txn.oncomplete = function () {
////            db.close();
////        };
////    };

////    function getContactByEmail(db, email) {
////        const txn = db.transaction('Contacts', 'readonly');
////        const store = txn.objectStore('Contacts');

////        // get the index from the Object Store
////        const index = store.index('email');
////        // query by indexes
////        let query = index.get(email);

////        // return the result object on success
////        query.onsuccess = (event) => {
////            console.table(query.result); // result objects
////        };

////        query.onerror = (event) => {
////            console.log(event.target.errorCode);
////        }

////        // close the database connection
////        txn.oncomplete = function () {
////            db.close();
////        };
////    }

////    function getAllContacts(db) {
////        const txn = db.transaction('Contacts', "readonly");
////        const objectStore = txn.objectStore('Contacts');

////        objectStore.openCursor().onsuccess = (event) => {
////            let cursor = event.target.result;
////            if (cursor) {
////                let contact = cursor.value;
////                console.log(contact);
////                // continue next record
////                cursor.continue();
////            }
////        };
////        // close the database connection
////        txn.oncomplete = function () {
////            db.close();
////        };
////    }


////    function deleteContact(db, id) {
////        // create a new transaction
////        const txn = db.transaction('Contacts', 'readwrite');

////        // get the Contacts object store
////        const store = txn.objectStore('Contacts');
////        //
////        let query = store.delete(id);

////        // handle the success case
////        query.onsuccess = function (event) {
////            console.log(event);
////        };

////        // handle the error case
////        query.onerror = function (event) {
////            console.log(event.target.errorCode);
////        }

////        // close the database once the 
////        // transaction completes
////        txn.oncomplete = function () {
////            db.close();
////        };

////    }
////})();