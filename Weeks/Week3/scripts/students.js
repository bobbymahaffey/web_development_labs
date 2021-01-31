// Storing table data
var students = '{"students": [{"Student Id": 918232423, "Email Address": "lynden.mahaffey@oit.edu"}, {"Student Id": "918232424", "Email Address": "gavin.mahaffey@oit.edu"}, {"Student Id": "918232425", "Email Address": "prestyn.mahaffey@oit.edu"} ]}'
return JSON.parse(students);

function initializeStudents 
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
        var studentId = students[i].studentId;
        var studentEmail = students[i].studentEmail;
        tableRows += "<tr><td>" + studentId + "</td><td>" + studentEmail + "</td></tr>";
    }
    document.getElementById("student-list").innerHTML = tableRows ;
}