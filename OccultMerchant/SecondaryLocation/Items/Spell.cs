using System;

namespace SecondaryLocation.Items
{
    public class Spell : ISpell
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string source { get; set; }
        public int price { get; set; }
        public int ItemType { get; set; }
        public int range { get; set; }
        public string target { get; set; }
        public string duration { get; set; }
        public string savingThrow { get; set; }
        public bool spellResistence { get; set; }
        public string casting { get; set; }
        public string component { get; set; }
        public string school { get; set; }
        public string level { get; set; }

        public Spell()
        {
            
        }

        public Spell(Item item, SpellWrappper spellWrappper)
        {
            this.id = item.id;
            this.name = item.name;
            this.description = item.description;
            this.source = item.source;
            this.price = item.price;
            this.ItemType = item.ItemType;
            this.range = spellWrappper.range;
            this.target = spellWrappper.target;
            this.duration = spellWrappper.duration;
            this.savingThrow = spellWrappper.savingThrow;
            this.casting = spellWrappper.casting;
            this.school = spellWrappper.school;
            this.level = spellWrappper.level;
        }
    }
}