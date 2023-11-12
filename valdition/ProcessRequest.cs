using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace valdition
{
    public class ProcessRequest
    {
        public String Name { get; set; }
        public String Major { get; set; }
        public int Year { get; set; }
        public String Description { get; set; }
        public int BondId { get; set; }
        public ProcessRequest(String name, String major,int year, String description,int bondId)
        {
            Name = name;
            Major = major;
            Year = year;
            Description = description;
            BondId = bondId;

        }

    }

    public class ProcessRequestValditor : AbstractValidator<ProcessRequest>
    {
        public ProcessRequestValditor()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Major).NotEmpty().WithMessage("Major is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.Year).InclusiveBetween(1,4).WithMessage("year of study must be between 1 and 4");
            RuleFor(x => x.BondId).InclusiveBetween(1122, 1122).WithMessage("there is no bond with this id");
        }
    }
}
