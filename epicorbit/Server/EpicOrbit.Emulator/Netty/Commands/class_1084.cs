using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
using System.Collections.Generic;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_1084 : ICommand {

        public short ID { get; set; } = 31328;
        public List<CCommandModule> commands;

        public class_1084(List<CCommandModule> param1 = null) {
            if (param1 == null) {
                this.commands = new List<CCommandModule>();
            } else {
                this.commands = param1;
            }
        }

        public void Read(IDataInput param1, ICommandLookup lookup) {
            this.commands.Clear();
            for (int i = param1.ReadInt(); i > 0; i--) {
                var tmp_0 = lookup.Lookup(param1) as CCommandModule;
                tmp_0.Read(param1, lookup);
                this.commands.Add(tmp_0);
            }
            param1.ReadShort();
        }

        public void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected void method_9(IDataOutput param1) {
            param1.WriteInt(this.commands.Count);
            foreach (var tmp_0 in this.commands) {
                tmp_0.Write(param1);
            }
            param1.WriteShort(23894);
        }
    }
}
