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

        public List<Education> MakeEducations(Guid userId)
        {
            return new List<Education> { new Education { BelongsTo = userId, Start = new DateTime(2012), End = new DateTime(2016) } };
        }

        public List<Project> MakeProjects(Guid userId)
        {
            return new List<Project>
            {
                new Project { BelongsTo = userId, Start = new DateTime(2017), End = new DateTime(2017), Description = "A curriculum vitae web service example for MindWorking."},
                new Project { BelongsTo = userId, Start = new DateTime(2017), End = new DateTime(2017), Description = "Web html crawler and alarm system for automated steam marked purchases."},
                new Project { BelongsTo = userId, Start = new DateTime(2016), End = new DateTime(2016), Description = "Optimizing the deployment process of the Kamstrup electricity department monolith installer by developing automated 1-click deployment."},
                new Project { BelongsTo = userId, Start = new DateTime(2016), End = new DateTime(2016), Description = "Opensource client-server system for Kamstrup external api integrators on a world-wide basis, displaying the use of SAML tokens and RESTful api creation."},
                new Project { BelongsTo = userId, Start = new DateTime(2015), End = new DateTime(2015), Description = "Specialization and final bachelor project with RushFiles, developing a JavaScript user behaviour analysis framework."},
            };
        }

        public List<Skill> MakeSkills(Guid userId)
        {
            return new List<Skill>()
            {
                new Skill {BelongsTo = userId, Description = "C#"},
                new Skill {BelongsTo = userId, Description = "IoC"},
                new Skill {BelongsTo = userId, Description = "Dependency Injection"},
                new Skill {BelongsTo = userId, Description = "Continous Delivery"},
                new Skill {BelongsTo = userId, Description = "Web services"},
                new Skill {BelongsTo = userId, Description = "Asp.net"},
                new Skill {BelongsTo = userId, Description = "Microservice architecture"},
                new Skill {BelongsTo = userId, Description = "WPF"},
                new Skill {BelongsTo = userId, Description = "React.js"},
                new Skill {BelongsTo = userId, Description = "MongoDb"},
                new Skill {BelongsTo = userId, Description = "MSSQL"},
                new Skill {BelongsTo = userId, Description = "CassandraDb"},
                new Skill {BelongsTo = userId, Description = "Scrum"}
            };
        }

        public List<WorkExperience> MakeWorkExperiences(Guid userId)
        {
            return new List<WorkExperience>
            {
                new WorkExperience {BelongsTo = userId, CompanyName = "Kamstrup", Start = new DateTime(2016), End = new DateTime(2017),  Position = "Software developer", Description = "Fullstack software developer at Kamstrup\'s Heat-Cooling-Water division. Currently working on establishing an analytics platform in .NET core using a microservice architecture in the azure cloud.\r\n\r\nAlso spent time creating and maintaining installers for a team of around 45 people. I have developed Windows InstallShield installers with custom integrated WPF dialogs. Implemented security solutions such as two-way SSL, token based front-end authentication, service-to-service authorization, in Azure Active Directory and also in an ADFS.\r\n\r\nOther things worth mentioning: proficient user of technologies such as MongoDB, MSSQL, Cassandra, EventHub, Log4net, Application Insights, Serilog, ReSharper, dependency injection, powershell scripting, SVN, Git, bitbucket, continuous delivery, TeamCity, and others."},
                new WorkExperience {BelongsTo = userId, CompanyName = "Kamstrup", Start = new DateTime(2015), End = new DateTime(2015),  Position = "Software developer bachelor student", Description = "I wrote my bachelor project in cooperation with the company RushFiles. The project involved a server module using the technologies MongoDB, a RESTful web api, and a client-side using HTML, CSS, JS, and the use of different JS frameworks."},
                new WorkExperience {BelongsTo = userId, CompanyName = "Kamstrup", Start = new DateTime(2014), End = new DateTime(2014),  Position = "Internship", Description = "Worked on an open source web client, integrating against Kamstrup\'s RESTful web service, for wireless measuring of electricity devices. The project was open source and in the end it was released to external integrators around the world.\r\n\r\nDone mainly in C#, in an MVC4 application. The solution had a server side for accessing the REST-service, and a client side for interacting with the devices in the system. \r\n\r\nThe project was fully covered with automated tests using testing technologies such as NUnit, TeamCity, dotCover, Sinon.js, Jasmine.js, chutzpah.js for teamcity integration, and dependency injection using RhinoMocks.\r\n\r\nI also worked with different technologies such as resharper, SVN, MongoDB, MSSQL, MSMQ, HTML, XSD-files, XML, SQL, CSS, and JavaScript including many different JS frameworks."}
            };
        }
    }
}
