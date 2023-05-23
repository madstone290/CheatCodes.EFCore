using Api.Data;

namespace Api.Features.Pivot
{
    public class PivotService
    {
        private readonly ApplicationDbContext _context;

        public PivotService(ApplicationDbContext context)
        {
            _context = context;
        }

        public dynamic GetPivot()
        {
            return _context.Receipts
                .Select(x => new
                {
                    Month = x.ReceiptDate.Month,
                    Quantity = x.Quantity
                })
                .GroupBy(x => x.Month)
                .Select(g => new
                {
                    Month1 = g.Key == 1 ? g.Sum(g => g.Quantity) : 0,
                    Month2 = g.Key == 2 ? g.Sum(g => g.Quantity) : 0,
                    Month3 = g.Key == 3 ? g.Sum(g => g.Quantity) : 0,
                    Month4 = g.Key == 4 ? g.Sum(g => g.Quantity) : 0,
                    Month5 = g.Key == 5 ? g.Sum(g => g.Quantity) : 0,
                    Month6 = g.Key == 6 ? g.Sum(g => g.Quantity) : 0,
                    Month7 = g.Key == 7 ? g.Sum(g => g.Quantity) : 0,
                    Month8 = g.Key == 8 ? g.Sum(g => g.Quantity) : 0,
                    Month9 = g.Key == 9 ? g.Sum(g => g.Quantity) : 0,
                    Month10 = g.Key == 10 ? g.Sum(g => g.Quantity) : 0,
                    Month11 = g.Key == 11 ? g.Sum(g => g.Quantity) : 0,
                    Month12 = g.Key == 12 ? g.Sum(g => g.Quantity) : 0,
                })
                .ToList();
        }

        public dynamic GetPivotDict()
        {
            return _context.Receipts
                .Select(x => new
                {
                    Month = x.ReceiptDate.Month,
                    Quantity = x.Quantity
                })
                .GroupBy(x => x.Month)
                .Select(g => new
                {
                    Month = g.Key,
                    TotalQuantity = g.Sum(x => x.Quantity)
                })
                .ToDictionary(g => g.Month, g => g.TotalQuantity);
        }

        public dynamic GetPivotWithItem()
        {
            return _context.Receipts
               .Select(x => new
               {
                   Month = x.ReceiptDate.Month,
                   Item = x.Item,
                   Quantity = x.Quantity
               })
               .GroupBy(x => new { x.Item })
               .Select(g => new
               {
                   Item = g.Key.Item,
                   Month1 = g.Where(x => x.Month == 1).Sum(x => x.Quantity),
                   Month2 = g.Where(x => x.Month == 2).Sum(x => x.Quantity),
                   Month3 = g.Where(x => x.Month == 3).Sum(x => x.Quantity),
                   Month4 = g.Where(x => x.Month == 4).Sum(x => x.Quantity),
                   Month5 = g.Where(x => x.Month == 5).Sum(x => x.Quantity),
                   Month6 = g.Where(x => x.Month == 6).Sum(x => x.Quantity),
                   Month7 = g.Where(x => x.Month == 7).Sum(x => x.Quantity),
                   Month8 = g.Where(x => x.Month == 8).Sum(x => x.Quantity),
                   Month9 = g.Where(x => x.Month == 9).Sum(x => x.Quantity),
                   Month10 = g.Where(x => x.Month == 10).Sum(x => x.Quantity),
                   Month11 = g.Where(x => x.Month == 11).Sum(x => x.Quantity),
                   Month12 = g.Where(x => x.Month == 12).Sum(x => x.Quantity)
               })
               .Select(g => g)
               .ToList();
        }


        public dynamic GetPivotWithItemImproved()
        {
            var receipts = _context.Receipts
                .Select(x => new
                {
                    Month = x.ReceiptDate.Month,
                    Item = x.Item,
                    Quantity = x.Quantity
                }).ToList();

            HashSet<int> months = new HashSet<int>();

            foreach (var r in receipts)
                months.Add(r.Month);

            var data = receipts.GroupBy(r => r.Item)
                .Select(g => new
                {
                    Item = g.Key,
                    Dict = g.GroupBy(x => x.Month).ToDictionary(g => g.Key, g => g.Sum(x => x.Quantity))
                });

            return data.ToList();
        }

    }
}
