using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Models;
using Contoso.Service;

namespace Contoso.Utitlity
{
    public static class Utility
    {
        public static List<State> GetAllStates()
        {
            var items = new List<State>
            {
                new State() {StateName = "Alabama", Value = "AL"},
                new State() {StateName = "Alaska", Value = "AK"},
                new State() {StateName = "Arizona", Value = "AZ"},
                new State() {StateName = "Arkansas", Value = "AR"},
                new State() {StateName = "California", Value = "CA"},
                new State() {StateName = "Colorado", Value = "CO"},
                new State() {StateName = "Connecticut", Value = "CT"},
                new State() {StateName = "District of Columbia", Value = "DC"},
                new State() {StateName = "Delaware", Value = "DE"},
                new State() {StateName = "Florida", Value = "FL"},
                new State() {StateName = "Georgia", Value = "GA"},
                new State() {StateName = "Hawaii", Value = "HI"},
                new State() {StateName = "Idaho", Value = "ID"},
                new State() {StateName = "Illinois", Value = "IL"},
                new State() {StateName = "Indiana", Value = "IN"},
                new State() {StateName = "Iowa", Value = "IA"},
                new State() {StateName = "Kansas", Value = "KS"},
                new State() {StateName = "Kentucky", Value = "KY"},
                new State() {StateName = "Louisiana", Value = "LA"},
                new State() {StateName = "Maine", Value = "ME"},
                new State() {StateName = "Maryland", Value = "MD"},
                new State() {StateName = "Massachusetts", Value = "MA"},
                new State() {StateName = "Michigan", Value = "MI"},
                new State() {StateName = "Minnesota", Value = "MN"},
                new State() {StateName = "Mississippi", Value = "MS"},
                new State() {StateName = "Missouri", Value = "MO"},
                new State() {StateName = "Montana", Value = "MT"},
                new State() {StateName = "Nebraska", Value = "NE"},
                new State() {StateName = "Nevada", Value = "NV"},
                new State() {StateName = "New Hampshire", Value = "NH"},
                new State() {StateName = "New Jersey", Value = "NJ"},
                new State() {StateName = "New Mexico", Value = "NM"},
                new State() {StateName = "New York", Value = "NY"},
                new State() {StateName = "North Carolina", Value = "NC"},
                new State() {StateName = "North Dakota", Value = "ND"},
                new State() {StateName = "Ohio", Value = "OH"},
                new State() {StateName = "Oklahoma", Value = "OK"},
                new State() {StateName = "Oregon", Value = "OR"},
                new State() {StateName = "Pennsylvania", Value = "PA"},
                new State() {StateName = "Rhode Island", Value = "RI"},
                new State() {StateName = "South Carolina", Value = "SC"},
                new State() {StateName = "South Dakota", Value = "SD"},
                new State() {StateName = "Tennessee", Value = "TN"},
                new State() {StateName = "Texas", Value = "TX"},
                new State() {StateName = "Utah", Value = "UT"},
                new State() {StateName = "Vermont", Value = "VT"},
                new State() {StateName = "Virginia", Value = "VA"},
                new State() {StateName = "Washington", Value = "WA"},
                new State() {StateName = "West Virginia", Value = "WV"},
                new State() {StateName = "Wisconsin", Value = "WI"},
                new State() {StateName = "Wyoming", Value = "WY"}
            };
            return items;
        }

        public static List<Instructor> GetAllInstructors()
        {
            InstructorService instructorService=new InstructorService();
            return instructorService.GetAllInstructor();
        }
        public static List<Departments> GetAllDepartments()
        {
            DepartmentService departmentService=new DepartmentService();
            return departmentService.GetAllDepartments();
        }
    }
}
