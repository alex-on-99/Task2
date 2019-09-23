using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDB
{
    internal class BlogContextInitializer :
        CreateDatabaseIfNotExists<LibraryDB.BlogContext>
    {
        // First Database initialization
        protected override void Seed(BlogContext context)
        {
            var articles = new List<Article>
            {
                new Article
                {
                    Name = "How much sugar can I eat?",
                    Date = new DateTime(2018, 12, 12, 11, 22, 0),
                    Text =
                        "World Health Organization recommends WHO calls on countries to reduce sugar intake by adults and children to reduce sugar intake to 10% of the total energy value of the diet. The WHO says that this will reduce the risk of overweight and tooth decay. Experts say that reducing sugar intake to 5% of daily calories will bring additional health benefits. Therefore, a not very active thirty-year-old man with a height of 180 cm and a weight of 70 kg is recommended to eat no more than 60 g of sugar per day. Now, according to statistics, the average Russian consumes 40 kg of sugar per year, which is about 109 g per day, by the population of the Russian Federation."
                },
                new Article
                {
                    Name = "How many grams of protein you need to consume per day to be healthy",
                    Date = new DateTime(2019, 2, 7, 10, 22, 0),
                    Text =
                        "The amount of protein is of great importance not only for building muscle mass, but also for overall health. Find out why protein is so important and how many grams you need to include in your diet for you. A protein consists of amino acid molecules that are linked to each other by a peptide bond. 20 amino acids are involved in protein synthesis in the body, eight of them(for an adult) are indispensable. This means that the body cannot synthesize these amino acids, they come only with food. Proteins are used for metabolism in cells, the production of enzymes, hormones, immune cells and antibodies, and other compounds that provide all the important functions of the body. Even the leanest diet includes some protein. The question is whether it is enough for health, good physical fitness and quality work of all systems and organs."
                },
                new Article
                {
                    Name = "Where to get simple and complex carbohydrates?",
                    Date = new DateTime(2019, 8, 22, 2, 10, 0),
                    Text =
                        "Simple carbohydrates are found in foods such as fruits, dairy products, sugar (pure carbohydrates), and honey. Complex carbohydrates are found in cereal products (cereals, hard pasta, bread, flour), potatoes, corn, and legumes. Despite the fact that flour belongs to complex carbohydrates, processed (refined) products from it, such as baked goods, buns, etc., belong to simple carbohydrates. In addition to simple and complex carbohydrates, there are also dietary fibers (fiber) that have such a complex structure that they are not digested by our body. Dietary fiber should be an integral part of your diet, as it ensures the functioning of the digestive system."
                },
            };

            var reviews = new List<Review>
            {
                new Review
                {
                    Name = "person1",
                    Date = new DateTime(2019, 06, 12, 11, 22, 0),
                    Text =
                        "Made neat an on be gave show snug tore. Sitting heart on it without me. As mr started arrival subject by believe. Steepest speaking up attended it as. Painful so he an comfort is manners. We leaf to snug on no need. To sure calm much most long me mean. As so seeing latter he should thirty whence."
                },
                new Review
                {
                    Name = "customer2",
                    Date = new DateTime(2019, 07, 2, 12, 22, 0),
                    Text =
                        "We leaf to snug on no need. An concluded sportsman offending so provision mr education. An stairs as be lovers uneasy. Called though excuse length ye needed it he having. Draw fond rank form nor the day eat. To sure calm much most long me mean. Fortune day out married parties. He in sportsman household otherwise it perceived instantly. undefined. Fat new smallness few supposing suspicion two. Ecstatic elegance gay but disposed. Mirth learn it he given. At none neat am do over will. "
                }
            };

            articles.ForEach(article => context.Articles.Add(article));
            reviews.ForEach(review => context.Reviewes.Add(review));
            context.SaveChanges();
        }
    }
}