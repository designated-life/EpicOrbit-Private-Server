using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
using System.Collections.Generic;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_815 : ICommand {

        public short ID { get; set; } = 26619;
        public List<int> list;

        public class_815(List<int> param1 = null) {
            if (param1 == null) {
                this.list = new List<int>();
            } else {
                this.list = param1;
            }
        }

        public void Read(IDataInput param1, ICommandLookup lookup) {
            param1.ReadShort();
            this.list.Clear();
            for (int i = param1.ReadInt(); i > 0; i--) {
                var tmp_0 = param1.Shift(param1.ReadInt(), 14);
                this.list.Add(tmp_0);
            }
        }

        public void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected void method_9(IDataOutput param1) {
            param1.WriteShort(32057);
            param1.WriteInt(this.list.Count);
            foreach (var tmp_0 in this.list) {
                param1.WriteInt(param1.Shift(tmp_0, 18));
            }
        }
    }
}
