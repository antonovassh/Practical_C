//using System.Runtime.Intrinsics.X86;

//Please, implement the CreateGroups method that takes a list of students as a first parameter and a list of groups as a second.

//The method should return a string that contains for all groups the next information:

// group name, average rating and the list of students in the group in the following format     

// [
//  {
//    "group": "group_name",
//    "description": "group_description",
//    "rating": average_rating,
//    "students": [
//      {
//        "FullName": "Name_of_student",
//        "AvgMark": students_rating
//      },
//      {
//    "FullName": "Ivan",
//        "AvgMark": 68.34
//      },
//      {
//    "FullName": "Oleh",
//        "AvgMark": 98.34
//      },
//      {
//    "FullName": "Katya",
//        "AvgMark": 88.34
//      }
//    ]
//  },
//  ...
//]
//        Tip: you can use GroupJoin to join collection with grouping. 

//        Use JSON serialization to generate output in the specified format.

//(You don't need to verify on null parameter values. Assume that parameters will always be not null)
using System.Text.Json;
using System.Text.RegularExpressions;

public static string CreateGroups(List<Student> students, List<Group> groups)
{
    var groupInfoList = groups.GroupJoin(students,
           group => group.Name,
           student => student.GroupName,
           (group, groupStudents) =>
           {
               var averageRating = groupStudents.Average(student => student.Rating);
               var studentInfoList = groupStudents.Select(student => new
               {
                   FullName = student.Name,
                   AvgMark = student.Rating
               }).ToList();

               return new
               {
                   group = group.Name,
                   description = group.Description,
                   rating = averageRating,
                   students = studentInfoList
               };
           }).ToList();

    return JsonSerializer.Serialize(groupInfoList, new JsonSerializerOptions
    {
        WriteIndented = true
    });
}