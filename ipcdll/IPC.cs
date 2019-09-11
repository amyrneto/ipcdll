using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipcdll
{
    public class IPC
    {

        private string memMapName, mutexName;
        private long memMapCapacity;
        private bool mutexCreated;
        private MemoryMappedFile mmf;
        private Mutex mutex;

        public bool isCreated()
        {
            return mutexCreated;
        }

        public bool AccessMemoryMap(string name, long size)
        {
            try
            {
                memMapName = name;
                mutexName = name + "_mutex";
                memMapCapacity = size;

                mmf = MemoryMappedFile.CreateOrOpen(name, size);
                mutex = new Mutex(true, mutexName, out mutexCreated);
                mutex.ReleaseMutex();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:", e.ToString());
                return false;
            }
        }

        public bool WriteMemoryMap(string name, int data, long offset = 0, long size = 0)
        {
            try
            {
                using (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting(name))
                {

                    Mutex mutex = Mutex.OpenExisting(name+"_mutex");
                    mutex.WaitOne();

                    using (MemoryMappedViewStream stream = mmf.CreateViewStream(offset, size))
                    {
                        BinaryWriter writer = new BinaryWriter(stream);
                        writer.Write(data);
                    }
                    mutex.ReleaseMutex();
                }
                return true;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Memory-mapped file does not exist. Run Process A first.");
                return false;
            }
        }

        public bool ReadMemoryMap(string name, out int data, long offset = 0, long size = 0)
        {
            try
            {
                using (MemoryMappedFile mmf = MemoryMappedFile.OpenExisting(name))
                {
                    Mutex mutex = Mutex.OpenExisting(name + "_mutex");
                    mutex.WaitOne();
                    using (MemoryMappedViewStream stream = mmf.CreateViewStream())
                    {
                        BinaryReader reader = new BinaryReader(stream);
                        data = reader.ReadInt32();                        
                    }
                    mutex.ReleaseMutex();
                }
                return true;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Memory-mapped file does not exist. Run Process A first.");
                data = 0;
                return false;
            }
        }
    }
}
