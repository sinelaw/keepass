/*
  KeePass Password Safe - The Open-Source Password Manager
  Copyright (C) 2003-2007 Dominik Reichl <dominik.reichl@t-online.de>

  This program is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics;

using KeePass.Forms;
using KeePass.Util;

using KeePassLib;
using KeePassLib.Cryptography.Cipher;

namespace KeePass.Plugins
{
	public interface IKeePassPluginHost
	{
		MainForm MainWindow
		{
			get;
		}

		PwDatabase Database
		{
			get;
		}

		CommandLineArgs CommandLineArgs
		{
			get;
		}

		CipherPool CipherPool
		{
			get;
		}
	}
}
