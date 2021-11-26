﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paper_io
{
    /// <summary>
    /// Основной класс, использьзуется для создания поля и отслеживания количества игроков
    /// </summary>
    class Game
    {
        /// <summary>
        /// Список всех игроков
        /// </summary>
        public Player[] Players;
        /// <summary>
        /// Размерность поля
        /// </summary>
        public Player[,] Room;
        /// <summary>
        /// Принимает количество игроков и делает поле размерностью n*n, где n- количество игроков * 10
        /// </summary>
        /// <param name="n"></param> Количество игроков
        public Game(byte n)
        {
            Players = new Player[n];
            Room = new Player[n * 10, n * 10];
        }
    }
}
