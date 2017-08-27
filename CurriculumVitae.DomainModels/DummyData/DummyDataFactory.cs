using System;
using System.Collections.Generic;
using CurriculumVitae.DomainModels.Specifications;
using CurriculumVitae.DomainModels.Users;

namespace CurriculumVitae.DomainModels.DummyData
{
    public class DummyDataFactory : IDummyDataFactory
    {
        public User MakeUser()
        {
            return new User { FirstName = "Jesper", LastName = "Møller Jakobsen", Email = "Jespermjakobsen@gmail.com" };
        }

        public List<Education> MakeEducations()
        {
            return new List<Education> { new Education { Start = new DateTime(2012), End = new DateTime(2016), Description = "Bachelor of Engineering, Information and Communication Technology. Specialization in Enterprise Engineering" } };
        }

        public List<Project> MakeProjects()
        {
            return new List<Project>
            {
                new Project { Start = new DateTime(2017), End = new DateTime(2017), Description = "A curriculum vitae web service example for MindWorking."},
                new Project { Start = new DateTime(2017), End = new DateTime(2017), Description = "Web html crawler and alarm system for automated steam marked purchases."},
                new Project { Start = new DateTime(2016), End = new DateTime(2016), Description = "Optimizing the deployment process of the Kamstrup electricity department monolith installer by developing automated 1-click deployment."},
                new Project { Start = new DateTime(2016), End = new DateTime(2016), Description = "Opensource client-server system for Kamstrup external api integrators on a world-wide basis, displaying the use of SAML tokens and RESTful api creation."},
                new Project { Start = new DateTime(2015, 1, 1), End = new DateTime(2015, 1, 1), Description = "Specialization and final bachelor project with RushFiles, developing a JavaScript user behaviour analysis framework."},
            };
        }

        public List<Skill> MakeSkills()
        {
            return new List<Skill>
            {
                new Skill {Description = "C#"},
                new Skill {Description = "IoC"},
                new Skill {Description = "Microsoft Azure"},
                new Skill {Description = "Dependency Injection"},
                new Skill {Description = "Continous Delivery"},
                new Skill {Description = "Web services"},
                new Skill {Description = "Asp.net"},
                new Skill {Description = "Microservice architecture"},
                new Skill {Description = "WPF"},
                new Skill {Description = "React.js"},
                new Skill {Description = "MongoDb"},
                new Skill {Description = "MSSQL"},
                new Skill {Description = "CassandraDb"},
                new Skill {Description = "Scrum"}
            };
        }

        public List<Company> MakeCompanies()
        {
            return new List<Company>
            {
                new Company {CompanyName = "Kamstrup", Start = new DateTime(2015, 2, 1),  Position = "Software developer", Description = "Fullstack software developer at Kamstrup\'s Heat-Cooling-Water division. Currently working on establishing an analytics platform in .NET core using a microservice architecture in the azure cloud.\r\n\r\nAlso spent time creating and maintaining installers for a team of around 45 people. I have developed Windows InstallShield installers with custom integrated WPF dialogs. Implemented security solutions such as two-way SSL, token based front-end authentication, service-to-service authorization, in Azure Active Directory and also in an ADFS.\r\n\r\nOther things worth mentioning: proficient user of technologies such as MongoDB, MSSQL, Cassandra, EventHub, Log4net, Application Insights, Serilog, ReSharper, dependency injection, powershell scripting, SVN, Git, bitbucket, continuous delivery, TeamCity, and others."},
                new Company {CompanyName = "Kamstrup", Start = new DateTime(2015, 8, 1), End = new DateTime(2015, 12, 1),  Position = "Software developer bachelor student", Description = "I wrote my bachelor project in cooperation with the company RushFiles. The project involved a server module using the technologies MongoDB, a RESTful web api, and a client-side using HTML, CSS, JS, and the use of different JS frameworks."},
                new Company {CompanyName = "Kamstrup", Start = new DateTime(2014, 7, 1), End = new DateTime(2014, 12, 1),  Position = "Internship", Description = "Worked on an open source web client, integrating against Kamstrup\'s RESTful web service, for wireless measuring of electricity devices. The project was open source and in the end it was released to external integrators around the world.\r\n\r\nDone mainly in C#, in an MVC4 application. The solution had a server side for accessing the REST-service, and a client side for interacting with the devices in the system. \r\n\r\nThe project was fully covered with automated tests using testing technologies such as NUnit, TeamCity, dotCover, Sinon.js, Jasmine.js, chutzpah.js for teamcity integration, and dependency injection using RhinoMocks.\r\n\r\nI also worked with different technologies such as resharper, SVN, MongoDB, MSSQL, MSMQ, HTML, XSD-files, XML, SQL, CSS, and JavaScript including many different JS frameworks."}
            };
        }
    }
}
