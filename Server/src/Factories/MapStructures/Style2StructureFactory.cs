﻿using MazeServer.src.map;
using MazeServer.src.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MazeServer.src.Factories.MapStructures
{
    class Style2StructureFactory: IStructureFactory
    {
        public Structure Create(Structures type)
        {
            switch (type)
            {
                case Structures.Wall:
                    return new BrickWall();
                case Structures.Floor:
                    return new CobblestoneFloor();
                default:
                    throw new NotImplementedException($"{type.ToString()} structure type is not supported");
            }
        }
    }
}
