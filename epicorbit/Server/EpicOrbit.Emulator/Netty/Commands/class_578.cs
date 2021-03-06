using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
using System.Collections.Generic;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_578 : ICommand {

        public short ID { get; set; } = 18100;
        public List<class_543> attributes;
        public int userId = 0;

        public class_578(int param1 = 0, List<class_543> param2 = null) {
            this.userId = param1;
            if (param2 == null) {
                this.attributes = new List<class_543>();
            } else {
                this.attributes = param2;
            }
        }

        public void Read(IDataInput param1, ICommandLookup lookup) {
            this.attributes.Clear();
            for (int i = param1.ReadInt(); i > 0; i--) {
                var tmp_0 = lookup.Lookup(param1) as class_543;
                tmp_0.Read(param1, lookup);
                this.attributes.Add(tmp_0);
            }
            this.userId = param1.ReadInt();
            this.userId = param1.Shift(this.userId, 25);
        }

        public void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected void method_9(IDataOutput param1) {
            param1.WriteInt(this.attributes.Count);
            foreach (var tmp_0 in this.attributes) {
                tmp_0.Write(param1);
            }
            param1.WriteInt(param1.Shift(this.userId, 7));
        }
    }
}
