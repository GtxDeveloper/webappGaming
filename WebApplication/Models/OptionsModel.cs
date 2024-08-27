using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class OptionsModel
    {
        private readonly GamePortalDbContext _gamePortalDbContext;

        public OptionsModel(GamePortalDbContext gamePortalDbContext)
        {
            _gamePortalDbContext = gamePortalDbContext;
        }
        public IEnumerable<Option> GetOptions()
        {
            return _gamePortalDbContext.Options.OrderBy(x => x.Order).ToList();
        }
        public IEnumerable<Option> GetSystemOptions()
        {
            return _gamePortalDbContext.Options.Where(o => o.IsSystem).OrderBy(x => x.Order).ToList();
        }
        public IEnumerable<Option> GetOptionsByRelation(string relation)
        {
            return _gamePortalDbContext.Options.Where(o => o.Relation.Equals(relation)).OrderBy(x => x.Order).ToList();
        }
        
        public Option GetOptionByName(string name)
        {
            return _gamePortalDbContext.Options.FirstOrDefault(o => o.Name == name);
        }

        public bool AddOption(Option option)
        {
            _gamePortalDbContext.Options.Add(option);
            return _gamePortalDbContext.SaveChanges() == 1 ? true : false;
        }

        public bool UpdateOption(Option updatedOption)
        {
            var opt = GetOptionById(updatedOption.Id);
            if(!opt.IsSystem)
            {
                opt.Name = updatedOption.Name;
            }
            opt.Key = updatedOption.Key;
            opt.Order = updatedOption.Order;
            opt.Relation = updatedOption.Relation;
            opt.Value = updatedOption.Value;

            return _gamePortalDbContext.SaveChanges() == 1 ? true : false;
        }

        public Option GetOptionById(int id)
        {
            return _gamePortalDbContext.Options.FirstOrDefault(o => o.Id == id);
        }

        public bool RemoveOption(Option removeOpt)
        {
            _gamePortalDbContext.Options.Remove(removeOpt);
            return _gamePortalDbContext.SaveChanges() == 1 ? true : false;
        }
    }
}
