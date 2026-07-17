//指令,由表现层发出
public interface ICommand : IBelongToAchitecture,ICanSetArchitecture
{
    void Excute();
}