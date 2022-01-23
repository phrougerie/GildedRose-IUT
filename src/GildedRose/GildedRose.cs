using System.Collections.Generic;
using GildedRose.Items;

namespace GildedRose
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
                UpdateQuality(Items[i]);
        }

        private void UpdateQuality(Item item)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                return;
            }

            if (item.Name == "Aged Brie" )
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.SellIn < 11)
                        {
                            IncreaseQuality(item);
                        }

                        if (item.SellIn < 6)
                        {
                            IncreaseQuality(item);
                        }
                    }
                }

            }
            else
            {

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {                    
                }
                else
                {
                    DecreaseQuality(item);
                }
                                
            }

            
            item.SellIn = item.SellIn - 1;
            

            if (item.SellIn < 0)
            {
                if (item.Name == "Aged Brie")
                {
                    IncreaseQuality(item);

                }
                else
                {
                    if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                    else
                    {
                        DecreaseQuality(item);
                    }
                }
            }
        }

        private static void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }

        private static void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            
        }
    }
}
