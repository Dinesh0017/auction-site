﻿using Gem_Auctions_Web.Models;

namespace Gem_Auctions_Web.Data.Services
{
    public class BidsService : IBidsService
    {
        private readonly ApplicationDbContext _context;

        public BidsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Bid bid)
        {
            _context.Bids.Add(bid);
            await _context.SaveChangesAsync();
        }
    }
}
