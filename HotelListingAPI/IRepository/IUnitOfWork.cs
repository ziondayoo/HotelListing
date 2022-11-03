using HotelListingAPI.Data;
using HotelListingAPI.Migrations;
using System;
using System.Threading.Tasks;

namespace HotelListingAPI.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();



    }
}
