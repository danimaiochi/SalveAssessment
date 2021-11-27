
$(document).ready(function () {
    populateClinics();
});

function populateClinics() {
    var select = document.getElementById("slt-clinic");
    $.get("Clinics/GetAll", function (data) {
        for(var i = 0; i < data.length; i++) {
            var opt = data[i];
            var el = document.createElement("option");
            el.textContent = opt.name;
            el.value = opt.id;
            select.appendChild(el);
        }
    });
}


function populateUsers() {

    var grid = document.getElementById("patient-list");
    var clinicId = document.getElementById("slt-clinic").value;
    $.get("Patients/Get?clinicId="+clinicId, function (data) {
        
        $(".grid-row").remove();

        for(var i = 0; i < data.length; i++) {
            var opt = data[i];
            var record = document.createElement("tr");
            record.classList = ["grid-row"];
            var id = document.createElement("td");
            id.textContent = opt.id;
            
            var clinicId = document.createElement("td");
            clinicId.textContent = opt.clinicId;
            
            var firstName = document.createElement("td");
            firstName.textContent = opt.firstName;
            
            var lastName = document.createElement("td");
            lastName.textContent = opt.lastName;
            
            var dateOfBirth = document.createElement("td");
            dateOfBirth.textContent = opt.dateOfBirth;
            
            record.appendChild(id);
            record.appendChild(clinicId);
            record.appendChild(firstName);
            record.appendChild(lastName);
            record.appendChild(dateOfBirth);
            
            grid.appendChild(record);
        }
        makeSortable();
    });
}
function sortTable(table, col, reverse) {
    var tb = table.tBodies[0], // use `<tbody>` to ignore `<thead>` and `<tfoot>` rows
        tr = Array.prototype.slice.call(tb.rows, 0), // put rows into array
        i;
    reverse = -((+reverse) || -1);
    tr = tr.sort(function (a, b) { // sort rows
        return reverse // `-1 *` if want opposite order
            * (a.cells[col].textContent.trim() // using `.textContent.trim()` for test
                    .localeCompare(b.cells[col].textContent.trim())
            );
    });
    for(i = 0; i < tr.length; ++i) tb.appendChild(tr[i]); // append each row in order
}

function makeSortable() {
    var table = document.getElementById("patients-table");
    var th = table.tHead, i;
    th && (th = th.rows[0]) && (th = th.cells);
    if (th) i = th.length;
    else return; // if no `<thead>` then do nothing
    while (--i >= 0) (function (i) {
        var dir = 1;
        th[i].addEventListener('click', function () {sortTable(table, i, (dir = 1 - dir))});
    }(i));
}
