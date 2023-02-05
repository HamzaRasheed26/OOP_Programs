using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDepartement.BL
{
    internal class HosePipe
    {
        private string material;
        private string shape;
        private float diameter;
        private float flowRate;

        public HosePipe(string material, string shape, float diameter, float flowRate)
        {
            this.material = material;
            this.shape = shape;
            this.diameter = diameter;
            this.flowRate = flowRate;
        }

        public string getMaterial()
        {
            return material;
        }
        public string getShape()
        {
            return shape;
        }
        public float getDiameter()
        {
            return diameter;
        }
        public float getFlowRate()
        {
            return flowRate;
        }

        public void setMaterial(string material)
        {
            this.material = material;
        }
        public void setShape(string shape)
        {
            this.shape = shape;
        }
        public void setDiameter(float diameter)
        {
            this.diameter = diameter;
        }
        public void setFlowRate(float flowRate)
        {
            this.flowRate = flowRate;
        }
    }
}
