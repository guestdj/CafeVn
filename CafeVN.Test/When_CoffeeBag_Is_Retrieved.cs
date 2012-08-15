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

        Establish context = () =>
                                        {
                                            _coffeeBags = new CoffeeBagRepository();
                                        };

        Because of = () =>
                                 {
                                     cafeVn = _coffeeBags.Get(1);
                                 };

        It should_populate_coffebag = () =>
                                                  {
                                                      cafeVn.Id.ShouldEqual(1);
                                                      cafeVn.Name.ShouldEqual("CafeVn");
                                                  };


    }

    public class CoffeeBagRepository
    {
        public CoffeeBag Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
