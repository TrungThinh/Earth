﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Earth.Data.EF.Interfaces.Entity
{
    /// <summary>
    ///     Resolve concurrency issue. 
    /// </summary>
    public interface IVersionEntity
    {
        [Timestamp]
        byte[] Version { get; set; }
    }
}
