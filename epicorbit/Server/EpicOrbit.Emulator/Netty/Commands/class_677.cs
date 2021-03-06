using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_677 : ICommand {

        public virtual short ID { get; set; } = 19478;
        public string lootId = "";

        public class_677(string param1 = "") {
            this.lootId = param1;
        }

        public virtual void Read(IDataInput param1, ICommandLookup lookup) {
            this.lootId = param1.ReadUTF();
        }

        public virtual void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected virtual void method_9(IDataOutput param1) {
            param1.WriteUTF(this.lootId);
        }
    }
}
