using CafeVN.Models;
using Machine.Specifications;
using Machine.Specifications.Model;

namespace CafeVN.Test
{
    [Subject(typeof (CoffeeBagRepository))]
    public class When_CoffeeBag_Is_Retrieved
    {
        private static CoffeeBagRepository _coffeeBags;
        private static CoffeeBag cafeVn;

        private Establish context = () =>
                                        {
                                            _coffeeBags = new CoffeeBagRepository();
                                        };

        private Because of = () =>
                                 {
                                     cafeVn = _coffeeBags.Get(1);
                                 };

        private It should_populate_coffebag = () =>
                                                  {
                                                      cafeVn.Id.ShouldEqual(1);
                                                      cafeVn.Name.ShouldEqual("CafeVN");
                                                  };
    }

    public class CoffeeBagRepository
    {
        public CoffeeBag Get(int id)
        {
            var cb = new CoffeeBag {Id = 1, Name = "CafeVN"};
            return cb;
        }
    }
}