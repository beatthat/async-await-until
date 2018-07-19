#if NET_4_6
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BeatThat.AsyncAwaitUntil
{
    public class WaitForBackgroundThread
    {
        public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
        {
            return Task.Run(() => { }).ConfigureAwait(false).GetAwaiter();
        }
    }
}
#endif