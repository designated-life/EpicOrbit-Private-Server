using EpicOrbit.Emulator.Netty.Attributes;
using EpicOrbit.Emulator.Netty.Interfaces;
namespace EpicOrbit.Emulator.Netty.Commands {

    [AutoDiscover("10.0.6435")]
    public class class_796 : ICommand {

        public virtual short ID { get; set; } = 9654;

        public class_796() {
        }

        public virtual void Read(IDataInput param1, ICommandLookup lookup) {
        }

        public virtual void Write(IDataOutput param1) {
            param1.WriteShort(ID);
            this.method_9(param1);
        }

        protected virtual void method_9(IDataOutput param1) {
        }
    }
}
