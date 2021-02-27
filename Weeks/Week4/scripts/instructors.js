// Storing table data
var instructors = '{"instructors": [{ "First" : "Bobby" , "Middle" : "Joe" , "Last" : "Mahaffey" } , { "First" : "Kristina" , "Middle" : "Marie" , "Last" : "Mahaffey" } , { "First" : "Kameron" , "Middle" : "Edward" , "Last" : "Mahaffey "}]}'


function getInstructors()
{
    return JSON.parse(instructors);
}

function initializeIstructors() 
{
     var data = getInstructors();

     displayInstructors(data.instructors);
}

// Displays instructors in a table
function displayInstructors(instructors) 
{
    var tableRows = "";
    for (i = 0; i < instructors.length; i++) 
	{
        var First = instructors[i].First;
        var Middle = instructors[i].Middle;
		var Last = instructors[i].Last;
        tableRows += "<tr><td>" + First + "</td><td>" + Middle + "</td><td>" + Last + "</td></tr>";
    }
    document.getElementById("instructors-list").innerHTML = tableRows ;
}