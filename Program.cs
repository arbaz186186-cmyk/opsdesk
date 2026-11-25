
Console.WriteLine("================================");
Console.WriteLine("          OPSDESK");
Console.WriteLine("   IT Operations Platform");
Console.WriteLine("================================");

string engineerName = "Arbaz";
int experience = 0;
bool isActive = true;

Console.WriteLine("Welcome, " + engineerName + "!");
Console.WriteLine("Role: Junior DevOps Engineer!");
Console.WriteLine("Experience: " + experience + " years!");
Console.WriteLine("System Status: Online");

// Employee Experience Check
if (experience >= 1)
{
    Console.WriteLine("Experienced Engineer");
}
else
{
    Console.WriteLine("Fresher Engineer");
}

// Employee Access Control
if (isActive && experience >= 1)
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Access Denied");
}

// Create Incident Ticket
string incidentId = "INC002";
string incidentTitle = "Network Connection Failed";
string priority = "Critical";

Console.WriteLine("\n----- NEW INCIDENT -----");
Console.WriteLine("Incident ID: " + incidentId);
Console.WriteLine("Title: " + incidentTitle);
Console.WriteLine("Priority: " + priority);

// Priority Alert
if (priority == "Critical")
{
    Console.WriteLine("URGENT: Immediate action required!");
}
else
{
    Console.WriteLine("Normal incident");
}

// Incident Status Management
string incidentStatus = "Open";

Console.WriteLine("Status: " + incidentStatus);

incidentStatus = "In Progress";
Console.WriteLine("Updated Status: " + incidentStatus);

incidentStatus = "Resolved";
Console.WriteLine("Final Status: " + incidentStatus);

// Multiple Incident Management
List<string> incidents = new List<string>();

incidents.Add("Server Down");
incidents.Add("Network Issue");
incidents.Add("Application Error");

Console.WriteLine("\n----- INCIDENT SUMMARY -----");

foreach (string incident in incidents)
{
    Console.WriteLine(incident);
}

Console.WriteLine("Total Incidents: " + incidents.Count);
