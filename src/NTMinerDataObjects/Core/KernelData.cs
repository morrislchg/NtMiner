﻿using System;
using System.Collections.Generic;

namespace NTMiner.Core {
    public class KernelData : IKernel, IDbEntity<Guid> {
        public KernelData() {
            this.AlgoIds = new List<Guid>();
        }

        public Guid GetId() {
            return this.Id;
        }

        public Guid Id { get; set; }

        public string Code { get; set; }

        public Guid BrandId { get; set; }

        public string Version { get; set; }

        public ulong PublishOn { get; set; }

        public string Package { get; set; }

        public long Size { get; set; }

        public PublishStatus PublishState { get; set; }

        public string HelpArg { get; set; }

        public string Notice { get; set; }

        public Guid KernelInputId { get; set; }
        public Guid KernelOutputId { get; set; }
        public List<Guid> AlgoIds { get; set; }
    }
}
