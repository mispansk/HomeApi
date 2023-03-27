﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Data.Queries
{

    /// <summary>
    /// Класс для передачи дополнительных параметров при обновлении свойств комнаты 
    /// </summary>
    public class UpdateRoomQuery
    {
        //public string NewName { get; }
        public int NewArea { get; set; }
        public bool NewGasConnected { get; set; }
        public int NewVoltage { get; set; }

        public UpdateRoomQuery(int newArea = 0, bool newGasConnected = false, int newVoltage = 0)
        {
            NewArea = newArea;
            NewGasConnected = newGasConnected;
            NewVoltage = newVoltage;
        }
    }
}
