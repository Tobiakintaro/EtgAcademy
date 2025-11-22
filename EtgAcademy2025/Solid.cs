using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtgAcademy2025
{
    internal class Solid
    {
    }

    /*S: Single Responsibility
     *O: Open-Close
     * 
     * 
     * 
     */


    #region Single Responsibility
    public class Car1
    {
        public void Drive() { }
    }


    public class Plane
    {
        public void Fly() { }

        public void Bank() { }
    }



    public class Vehicle()
    {
        public void Fly() { }
        public void Drive() { }

    }
    #endregion


    #region Open-Close

    public abstract class Shape
    {
        public abstract string Squeeze();

        public virtual double GetArea()
        {
            return 2.0;
        }
    }

    public class Circle : Shape
    {

        public override string Squeeze()
        {
            throw new NotImplementedException();
        }

        public override double GetArea()
        {
            return Math.PI * 2 * 2;
        }
    }


    public class Square : Shape
    {
        public override string Squeeze()
        {
            throw new NotImplementedException();
        }


        public void KillSquare()
        {
            throw new NotImplementedException();
        }

    }



    public class SpecialSquare : Square
    {
        public void WakeSquare()
        {
            throw new NotImplementedException();
        }


    }


    #endregion


    #region Liskov Sub
    public abstract class Bird
    {

        public virtual void Fly() { }
    }


    public class Hawk : Bird
    {

        public override void Fly()
        {

        }
    }
    public class Eagle : Bird
    {

        public override void Fly()
        {

        }
    }


    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new Exception("I cant fly");

        }
    }




    #endregion



    #region Interface Segregation


    public interface IDomesticWorker
    {
        public void Clean(string Soap, string Liquid);
        public void Walk();
    }


    public interface IBodyGuide
    {
        public void Protect();
    }


    public class DomesticWorker : IDomesticWorker, IBodyGuide
    {

        public void Clean(string Soap, string Liquid)
        {

        }

        public void Walk()
        {

        }


        public void Protect()
        {

        }

    }

    public class Testxyx
    {
        private readonly IBodyGuide _bodyG;
        private readonly IDomesticWorker _dm;

        public Testxyx(IBodyGuide bodyGuide, IDomesticWorker dm)
        {
            _bodyG = bodyGuide;
            _dm = dm;
        }



        public void main()
        {

            _dm.Walk();
            _dm.Clean("Lux", "Water");

            _bodyG.Protect();
        }




    }

    #endregion


    #region D — Dependency Inversion Principle (DIP)

    //Badsample
    public class LightBulb
    {
        public void TurnOn()
        {

        }
        public void TurnOff()
        {

        }
    }


    public class Switch
    {
        private readonly LightBulb _lightBulb;


        public Switch()
        {
            _lightBulb = new LightBulb(); //Tighly coupled

            _lightBulb.TurnOn();
        }


        public void TurnOn() => _lightBulb.TurnOn();

        public void TurnOff() => _lightBulb.TurnOff();


    }

    //Good sample

    public interface IDevice
    {
        public void TurnOn();
        public void TurnOff();

    }


    public class LightBulb_ : IDevice
    {
        public void TurnOn()
        {

        }
        public void TurnOff()
        {

        }

    }

    public class Stereo : IDevice
    {
        public void TurnOn()
        {

        }
        public void TurnOff()
        {

        }

    }



    public class Switch_
    {
        private readonly IDevice _device;
        public Switch_(IDevice device)
        {
            _device = device;
        }


        public void TurnOn()
        {
            _device.TurnOn();
        }
        public void TurnOff()
        {
            _device.TurnOff();
        }

    }




    public class Useage
    {
        public void doStuff()
        {
            var bulbSwitch = new Switch_(new LightBulb_());

            var stereoSwitch = new Switch_(new Stereo());


            stereoSwitch.TurnOff();


        }
    }




    #endregion




    public class SwitchX
    {
        public virtual void TurnOn()
        {

        }

        public virtual void TurnOff()
        {

        }
    }


    public class Xbox : SwitchX
    {

        public override void TurnOn()
        {

        }
        public override void TurnOff()
        {

        }


    }

    public class PS5 : SwitchX
    {

        public override void TurnOn()
        {

        }
        public override void TurnOff()
        {

        }


    }



    public class SwitchThings()
    {

        public void Dothis()
        {
            SwitchX switchPs = new PS5();

            switchPs.TurnOff();
        }


    }








}