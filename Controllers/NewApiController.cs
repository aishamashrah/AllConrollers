using Microsoft.AspNetCore.Mvc;
using StudentDirectoryApi.Models;
namespace day2ApiInput.Controllers;

[ApiController]
[Route("[controller]")]
public class NewApiController : ControllerBase
{
    [HttpGet]
    [Route("Hello/{name}")]

    public string SayHello(string name)
    {
        return $"Whats up {name}!";
    }


    [HttpGet]
    [Route("Adding/{number1}/{number2}")]
    public string Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        int answer = convertNum1 + convertNum2;
        return $"{convertNum1} + {convertNum2} = {answer} ";
    }
    [HttpGet]
    [Route("Reverse/{orignial}")]

    public string ReversIt(string orignial)
    {
        char[] array = orignial.ToCharArray();
        string reverse = String.Empty;
        for (int i = array.Length - 1; i > -1; i--)
        {
            reverse += array[i];
        }
        return $"YOUR ORIGINAL INPUT: {orignial} \nYOUR INPUT BUT REVERESED: {reverse}";
    }
    [HttpGet]
    [Route("Asking/{name}/{time}")]

    public string AskingQuestions(string name, int time)
    {
        return $"Whats up {name}, you woke up at {time} !";
    }

    [HttpGet]
    [Route("Mad/{adjective}/{noun}/{noun1}/{noun2}/{noun4}/{adverb}/{verbOne}/{adjective1}/{VerbTwo}/{Noun3}")]

    public string SayHello(string adjective, string noun, string noun1, string noun2, string adverb, string verbOne, string adjective1, string noun4, string VerbTwo, string Noun3)
    {
        return $"The {adjective} and the + {noun} + {noun1} like the {noun2} beforhand {noun4} {adverb} {verbOne} them now thses {adjective1} creactures have {VerbTwo} in to {Noun3}";
    }

    //Console.WriteLine(
    [HttpGet]
    [Route("comparing/{number1}/{number2}")]
    public string GreatOrLessThan(string number1, string number2)
    {
        long convertNum1 = Convert.ToInt64(number1);
        long convertNum2 = Convert.ToInt64(number2);
        string answer = "apple";

        if (convertNum1 > convertNum2)
        {
            answer = $"{convertNum1} > {convertNum2} \n{convertNum2} < {convertNum1}";
        }
        if (convertNum1 < convertNum2)
        {
            answer = $"{convertNum2} > {convertNum1} \n{convertNum1} < {convertNum2}";
        }
        else if (convertNum1 == convertNum2)
        {
            answer = $"{convertNum1} = {convertNum2} \n{convertNum2} = {convertNum1}";
        }

        return answer;


    }

     [HttpGet]
    [Route("OddOrEven/{number1}")]
    public string Math(string number1)
    {
        int convertNum1 = Convert.ToInt32(number1);

        return convertNum1 % 2 == 0 ? $"You're number of {convertNum1} is even" : $"You're number of {convertNum1} is odd"; 
    }


[HttpGet]
    [Route("pick/{number1}")]
    public string Math(int number1)
    {
        //int convertNum1 = Convert.ToInt32(number1);
        string answer = "";
        string message = "";

        if (number1 == 1)
        {
            string[] American = { "McDonald", "Chick-fil-A", "Taco Bell", "Subway", "Tasty Pot", "Market Tavern", "Island Gourmet Restaurant", "LumberJack's Restaurant", "burger king", "CARL'S JR", "IN and Out burger" };
            message = "American Food ~ " ;
            Random random = new Random();
            int randomOut = random.Next(0, 11);
            answer = American[randomOut];
        }
        if (number1 == 2)
        {
            string[] INDIAN = { "Maharaja Indian Cuisine", "India 4 U Restaurant and Bar", "Tandoori Grill", "The Amarvilas","Swagat Indian Cuisine", "Royal India Cuisine & Bar", "Curry on wheels", "Shan-E-Punjab", "Indian food bus", "Indian Cafe"};
            message = " you choose Indian Food ~ ";
            Random random = new Random();
            int randomOut = random.Next(0, 11);
            answer = INDIAN[randomOut];
        }
        if (number1 == 3)
        {
            string[] ITALIAN = { "Angelina's Spaghetti House", "Express Pizza & GriLL","Mezzo", "De Vega Brothers", "Romano's Macaroni Grill", "Olive Garden Italian Restaurant", "Padella Italiana", "De Vinci's Delicatessen & Catering", "Giovannis Catering", "De Vinci's Delicatessen" };
            message = "You choose Italian Food ~ ";
            Random random = new Random();
            int randomOut = random.Next(0, 11);
            answer = ITALIAN[randomOut];
        }
        return $"{message} Go To: {answer}";
    }


     public List<StudentListModel> studentsList = new List<StudentListModel>()
        {
            
            new StudentListModel(){
                firstName = "Harrison",
                lastName = "Busby",
                slackName = "Harrison Busby",
                email = "hbusby@codestack.co",
                hobbies = "Piano"
            },
            new StudentListModel(){
                firstName = "Brandon",
                lastName = "Le",
                slackName = "Brandon Le",
                email = "ble@codestack.co",
                hobbies = "Eating & Sleeping"
            },
            new StudentListModel(){
                firstName = "Jessie",
                lastName = "Lamzon",
                slackName = "Jessie Lamzon",
                email = "jlamzon@codestack.co",
                hobbies = "Eating, traveling"
            },
            new StudentListModel(){
                firstName = "Andrea",
                lastName = "Burr",
                slackName = "Andrea Burr",
                email = "aburr@codestack.co",
                hobbies = "Horse Riding"
            },
            new StudentListModel(){
                firstName = "Daniel",
                lastName = "Decoito",
                slackName = "Daniel Decoito",
                email = "DanielDecoito@gmail.com",
                hobbies = "bears, beets, battlestar galactica"
            },
            new StudentListModel(){
                firstName = "Pedro",
                lastName = "Castaneda",
                slackName = "Pedro Castaneda",
                email = "pcastaneda@codestack.co",
                hobbies = "hiking and traveling"
            },
            new StudentListModel(){
                firstName = "Jeremy",
                lastName = "Lapham",
                slackName = "Muscle Baby",
                email = "jlapham@codestack.co",
                hobbies = "Body building, powerlifting, wrestling"
            },
            new StudentListModel(){
                firstName = "Jacob",
                lastName = "Dekok",
                slackName = "Jacob Dekok",
                email = "jdekok@codestack.co",
                hobbies = "Copying Jeremy, Body building, powerlifting, wrestling"
            },
            new StudentListModel(){
                firstName = "Kenneth",
                lastName = "Fujimura",
                slackName = "Kenneth Fujimura",
                email = "kfujimura@codestack.co",
                hobbies = ""
            },
            new StudentListModel(){
                firstName = "Fernando",
                lastName = "Aguilar",
                slackName = "Freddy Aguilar",
                email = "faguilar@codestack.co",
                hobbies = "Playing video games, reading, writing"
            },
             new StudentListModel(){
                firstName = "Jovann",
                lastName = "Contreras",
                slackName = "Jovann Contreras",
                email = "jcontreras@codestack.co",
                hobbies = "Like collecting comics"
            },
             new StudentListModel(){
                firstName = "Andrew",
                lastName = "Nilsson",
                slackName = "Drew Nilsson",
                email = "anilsson@codestack.co",
                hobbies = "Playing video games"
            },
             new StudentListModel(){
                firstName = "Lerissa",
                lastName = "Lazar",
                slackName = "Lerissa Lazar",
                email = "llazar@codestack.co",
                hobbies = "Drawing & watching anime"
            },
             new StudentListModel(){
                firstName = "N. Harrison",
                lastName = "Wilkins",
                slackName = "Harrison Wilkins",
                email = "nwilkins@codestack.co",
                hobbies = "Skating, coding"
            },
             new StudentListModel(){
                firstName = "Madeline",
                lastName = "Gowan",
                slackName = "Maddie Gowan",
                email = "mgowan@codestack.co",
                hobbies = "Rodents"
            },
             new StudentListModel(){
                firstName = "Manuel",
                lastName = "Leyva",
                slackName = "Manuel Leyva",
                email = "mleyva@codestack.co",
                hobbies = "Photography"
            },
             new StudentListModel(){
                firstName = "Elizar ",
                lastName = "Garcia",
                slackName = "Elizar Garcia",
                email = "Egarcia@codestack.co",
                hobbies = "Bowling and Sleeping"
            },
             new StudentListModel(){
                firstName = "Mark",
                lastName = "Ramirez",
                slackName = "mark ramirez",
                email = "mramirez@codestack.co",
                hobbies = "games and drinking way too much water"
            },
             new StudentListModel(){
                firstName = "Chris ",
                lastName = "Martinez",
                slackName = "Chris Martinez",
                email = "cmartinez@codestack.co",
                hobbies = "Playing Ping Pong"
            },
             new StudentListModel(){
                firstName = "Samuel ",
                lastName = "Laguna",
                slackName = "Samuel Laguna",
                email = "slaguna@codestack.co",
                hobbies = "unknown"
            },
             new StudentListModel(){
                firstName = "Isaiah ",
                lastName = "Ferguson",
                slackName = "Isaiah Ferguson",
                email = "IFerguson@codestack.co",
                hobbies = "Martial Arts, Tricking, Hiking, and Watching slice of life anime"
            },
             new StudentListModel(){
                firstName = "John",
                lastName = "Magpantay",
                slackName = "John Magpantay",
                email = "jmagpantay@codestack.co",
                hobbies = "FPS games"
            },
             new StudentListModel(){
                firstName = "Reed ",
                lastName = "Goodwin",
                slackName = "Reed Goodwin",
                email = "rgoodwin@codestack.co",
                hobbies = "Hiking, video games and skateboarding"
            },
             new StudentListModel(){
                firstName = "Amar ",
                lastName = "Mann",
                slackName = "Amar",
                email = "amann@codestack.co",
                hobbies = "Kicking rocks"
            },
             new StudentListModel(){
                firstName = "Marcel ",
                lastName = "Rodriguez",
                slackName = "Marcel Rodriguez",
                email = "mrodriguez@codestack.co",
                hobbies = "unknown"
            },
             new StudentListModel(){
                firstName = "Richard ",
                lastName = "Johnson",
                slackName = "Richard Johnson",
                email = "rjohnson@codestack.co",
                hobbies = "Watching youtube, sketching, playing video games"
            },
             new StudentListModel(){
                firstName = "Ulises ",
                lastName = "Ortega",
                slackName = "Ulises Ortega",
                email = "uortega@codestack.co",
                hobbies = "Video Games, Rollerblading, Board Games"
            },
             new StudentListModel(){
                firstName = "Caroline ",
                lastName = "Hana",
                slackName = "Caroline Hana",
                email = "chana@codestack.co",
                hobbies = "video games, anime, hanging out w friends"
            },
             new StudentListModel(){
                firstName = "Aisha ",
                lastName = "Mashrah",
                slackName = "Aisha Mashrah",
                email = "amashrah@codestack.co",
                hobbies = "painting"
            },
             new StudentListModel(){
                firstName = " Shaun",
                lastName = "Aguirre-Reyes",
                slackName = "saguirre-reyes",
                email = "saguirre-reyes@codestack.co",
                hobbies = "Writing, Listening to music"
            },
             new StudentListModel(){
                firstName = "Griffin ",
                lastName = "Parker",
                slackName = "Griffin Parker",
                email = "gparker@codestack.co",
                hobbies = "Singing, Reading, Playing Video Games"
            },
             new StudentListModel(){
                firstName = " Kent",
                lastName = "Tupas",
                slackName = "Kent Tupas",
                email = "ktupas@codestack.co",
                hobbies = " anime, osu player, drawing"
            }
        };


    //endpoint that gets a student by their first name
    [HttpGet]
    [Route("GetStudentByFirstName/{studentFirstName}")]
    public StudentListModel GetStudentByFirstName(string studentFirstName)
    {
        StudentListModel result = new StudentListModel()
        {
            firstName = "N/A",
            lastName = "N/A",
            slackName = "N/A",
            email = "N/A",
            hobbies = "N/A"
        };

        for (int i = 0; i < studentsList.Count; i++)
        {
            // condition to check the studentlist firstname to our variable firstname

            if (studentsList[i].firstName == studentFirstName)
            {
                result = studentsList[i];
                break;
            }
        
        }

        return result;
    }


    
}








