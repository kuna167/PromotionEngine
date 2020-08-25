using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    abstract class Factory
    {
        public abstract IPromotion CreatePromotion();
    }
    abstract class FactoryCD
    {
        public abstract IPromotionCD CreatePromotionCD();
    }
    class FactoryA:Factory
    {
        public override IPromotion CreatePromotion()
        {
            return new PromotionA();
        }
    }
    class FactoryB : Factory
    {
        public override IPromotion CreatePromotion()
        {
            return new PromotionB();
        }
    }
    class FactoryPromoCD : FactoryCD
    {
        public override IPromotionCD CreatePromotionCD()
        {
            return new PromotionCD();
        }
    }
}
