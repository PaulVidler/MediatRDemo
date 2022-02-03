using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    // instead of classes below, we'll use the new records feature.
    // records are mostly immutable
    //public class GetPersonListQuery1 : IRequest<List<PersonModel>>
    //{
    //}

    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
}
