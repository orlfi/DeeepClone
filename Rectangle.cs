using System;
using System.Text.Json;

namespace DeepClone 
{
    [Serializable]
    public class Rectangle: iClone
    {
        public Point Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Point position, int width, int height) {
            Position = position;
            Width = width;
            Height = height;
        }

        public void  Move(Point position)
        {
            Position = position;
        }

        public iClone Clone()
        {
            Rectangle result = null;
            string jsonObj = JsonSerializer.Serialize(this);   
            result = JsonSerializer.Deserialize<Rectangle>(jsonObj);
            return result;
        }

        public void GetInfo()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"X:{Position.X} Y:{Position.Y} W:{Width} H:{Height}";
        }
    }
}