﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/

namespace ZyGames.Tianjiexing.Model.Enum
{
    public enum ServerCombatStage
    {
        Close = -1,
        /// <summary>
        /// 报名
        /// </summary>
        Apply = 0,
        /// <summary>
        /// 服内淘汰赛
        /// </summary>
        serverkonckout = 1,
        /// <summary>
        /// 区内淘汰赛
        /// </summary>
        finalskonckout = 2,
        /// <summary>
        /// 32强
        /// </summary>
        finals_32 = 3,
        /// <summary>
        /// 16强
        /// </summary>
        finals_16 = 4,
        /// <summary>
        ///  8强赛
        /// </summary>
        quarter_final = 5,
        /// <summary>
        /// 半决赛
        /// </summary>
        semi_final = 6,
        /// <summary>
        /// 决赛
        /// </summary>
        final = 7,
        /// <summary>
        /// 冠军
        /// </summary>
        champion = 8,
    }
}