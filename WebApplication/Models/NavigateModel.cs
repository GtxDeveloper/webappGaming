using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class NavigateModel
    {
        private readonly GamePortalDbContext _gamePortalDbContext;

        public NavigateModel(GamePortalDbContext gamePortalDbContext)
        {
            _gamePortalDbContext = gamePortalDbContext;
        }
        
        public List<Navigate> GetNavigateTree()
        {
            return IniteChilds().Where(n => n.Parent_Id == null).OrderBy(nE=> nE.Order).ToList();
        }
        private List<Navigate> IniteChilds()
        {
            var list = _gamePortalDbContext.Navigates.ToList();         // получили все нав бары

            foreach (var oneItem in list)
            {
                oneItem.Childs = new List<Navigate>();

                foreach (var allItem in _gamePortalDbContext.Navigates.ToList())
                {
                    if (oneItem.Id == allItem.Parent_Id) {
                        oneItem.Childs.Add(allItem);
                    }
                }
            }
            return list;
        }
        public void AddTemporaryNavigateElement(Navigate navigate)
        {
            _gamePortalDbContext.Navigates.Add(navigate);
        }
    }
}
