// Storing table data
var students = '{"students": [{"Id":"918232423", "Email":"lynden.mahaffey@oit.edu"},{"Id":"918232424","Email":"gavin.mahaffey@oit.edu"}, {"Id":"918232425","Email":"prestyn.mahaffey@oit.edu"}]}'


function getStudents()
{
    return JSON.parse(students);
}

function initializeStudents() 
{
     var data = getStudents();

     displayStudents(data.students);
}

// Displays students in a table
function displayStudents(students) 
{
    var tableRows = "";
    for (i = 0; i < students.length; i++) 
	{
        var Id = students[i].Id;
        var Email = students[i].Email;
        tableRows += "<tr><td>" + Id + "</td><td>" + Email + "</td></tr>";
    }
    document.getElementById("student-list").innerHTML = tableRows ;
}