//Please, create Department class with public string property Name, int Id and Worker Manager.

//     Create constructor with string, int and Manager parameters for initializing the properties.



//Create Worker class with public int property Id, string Name, decimal Salary and Department Department.

//     Create constructor with string, decimal, Department parameters to initialize the properties.

//     Implement public Serialize method that returns string that contains serialized Worker object in json format.

//     Worker that is created like this 

//         Worker w = new Worker("Anna", 700, new Department("Mechanics", 1, new Worker("Tom", 600, null))); *
//     should be serialized into the next string:     

// {
//    "Full name": "Anna",
//  "Salary": 700,
//  "Department": {
//        "Name": "Mechanics",
//    "Id": 1,
//    "Manager": {
//            "Full name": "Tom",
//      "Salary": 600
//    }
//    }
//}
//note that Id property should not be serialized and Name property should be represented as Full name

//     Also, implement public static method Deserialize that takes a string as a parameter and returns a deserialized Worker object from it.
using System.Text.Json.Serialization;
using System.Text.Json;

public class Department
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Worker Manager { get; set; }

    public Department(string name, int id, Worker manager)
    {
        Name = name;
        Id = id;
        Manager = manager;
    }
}


public class Worker
{
    [JsonIgnore]
    public int Id { get; set; }

    [JsonPropertyName("Full name")]
    public string Name { get; set; }

    public decimal Salary { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Department Department { get; set; }

    public Worker(string name, decimal salary, Department department)
    {
        Name = name;
        Salary = salary;
        Department = department;

    }

    public string Serialize()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(this, options);
        return jsonString;
    }
    public static Worker Deserialize(string str)
    {
        return JsonSerializer.Deserialize<Worker>(str);
    }
}