using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Collections;

namespace CustomerDatabaseApplication
{
    class CustomerIOServer<T> where T : CustomerObject
    {
        private string dataDirectoryPath;
        private string objectPath;
        private string objectName;
        private const int FIRST_OBJECT_INDEX = 1;
        public const int ERROR = -1;
        public const int OK = 0;

        public CustomerIOServer()
        {
            // Get Object Type
            Type parameterType = typeof(T);
            // Get Object Name
            objectName = parameterType.Name;
            // Get current directory path
            dataDirectoryPath = Directory.GetCurrentDirectory() + @"\serverData\";

            // Get the Path to object data
            objectPath = dataDirectoryPath + objectName + @".txt";

            // If the data directory path does not exist
            if (Directory.Exists(dataDirectoryPath) == false)
            {
                // Create the data directory path
                DirectoryInfo direct = Directory.CreateDirectory(dataDirectoryPath);
            }


            // If Object file does not exist
            if (File.Exists(objectPath) == false)
            {
                // Create the file
                using (FileStream fs = File.Create(objectPath))
                {
                    // Make the first line the next ID to be given out
                    Byte[] info = new UTF8Encoding(true).GetBytes("0");
                    // Write the data to file
                    fs.Write(info, 0, info.Length);
                }
                // Let the world know we created something
                //Console.WriteLine(customerPath + " created!");
            }
        }

        // Insert Object
        public int insert(T newObject)
        {
            List<string> al = new List<string>();

            // Read the file into the list
            ReadFile(objectPath, al);

            // Get Next Object Id
            int nextObjectId = Convert.ToInt16((string)al[0]);

            // Set Object ID to Next Object ID
            newObject.Id = nextObjectId;
            // Add Object String to the end of the list
            al.Add(newObject.ToString());

            // Increment Next Object ID
            nextObjectId++;
            // Replace next object id in the list 
            al[0] = nextObjectId.ToString();

            // Write the list back to file
            UpdateFile(objectPath, al);

            return 0;
        }

        // Read Object Record by Id
        public T findById(int findId)
        {
            List<string> al = new List<string>();

            // Read the object file into the list
            ReadFile(objectPath, al);

            // If there are no objects in the file
            if (al.Count <= FIRST_OBJECT_INDEX)
            {
                // Return Null
                return default(T);
            }

            // Set object to blank object
            T objectFound = default(T);

            // Set the index, to the start of object records
            int index = FIRST_OBJECT_INDEX;
            // Read through the list of records
            while (index < al.Count)
            {
                T currentObjectRecord = (T)Activator.CreateInstance(typeof(T), al[index]);

                // If the current objecct equals the search Id
                if (currentObjectRecord.Id == findId)
                {
                    // Copy the current object record to the return object
                    objectFound = currentObjectRecord;
                    // Stop searching
                    break;
                }

                // Increment index for next iteration
                index++;
            }

            // Return the found object
            return objectFound;
        }

        // Read all objects
        public List<T> findAll()
        {
            List<string> al = new List<string>();

            // Read the object file into the list
            ReadFile(objectPath, al);

            // If there are no objects in the file
            if (al.Count <= FIRST_OBJECT_INDEX)
            {
                // Return Null
                return default(List<T>);
            }

            // Set object to blank object
            List<T> objectList = new List<T>();

            // Set the index, to the start of object records
            int index = FIRST_OBJECT_INDEX;
            // Read through the list of records
            while (index < al.Count)
            {
                // Add the object to the list
                objectList.Add((T)Activator.CreateInstance(typeof(T), al[index]));

                // Increment index for next iteration
                index++;
            }

            // Return the found object
            return objectList;
        }

        // Update Object Record by ObjectId
        public int update(T updatedObject)
        {
            int returnValue = ERROR;

            // Read Entire Object File to Memory
            List<string> al = new List<string>();

            // Read the object file into the list
            ReadFile(objectPath, al);

            // Set the index, to the start of object records
            int index = FIRST_OBJECT_INDEX;
            // Read through the list of records
            while (index < al.Count)
            {
                T currentObjectRecord = (T)Activator.CreateInstance(typeof(T), al[index]);

                // If the current object equals the search Id
                if (currentObjectRecord.Id == updatedObject.Id)
                {
                    // Replace the current line with the updatedObject information
                    al[index] = updatedObject.ToString();
                    // Set the return value to OK
                    returnValue = OK;
                    // Stop searching
                    break;
                }

                // Increment index for next iteration
                index++;
            }

            // Write the list back to file
            UpdateFile(objectPath, al);

            return returnValue;
        }

        // Delete Object Record by ObjectId
        public int deleteById(int deleteId)
        {
            int returnValue = ERROR;

            // Read Entire Object File to Memory
            List<string> al = new List<string>();

            // Read the object file into the list
            ReadFile(objectPath, al);

            // Set the index, to the start of object records
            int index = FIRST_OBJECT_INDEX;
            // Read through the list of records
            while (index < al.Count)
            {
                T currentObjectRecord = (T)Activator.CreateInstance(typeof(T), al[index]);

                // If the current object equals the search Id
                if (currentObjectRecord.Id == deleteId)
                {
                    al.RemoveAt(index);
                    // Set the return value to OK
                    returnValue = OK;
                    // Stop searching
                    break;
                }

                // Increment index for next iteration
                index++;
            }

            // Write the list back to file
            UpdateFile(objectPath, al);

            return returnValue;
        }

        private void ReadFile(string filePath, List<string> fileData)
        {
            // Create an object to read the file
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;

                // While the stream reader has not reached the end of the file
                while ((line = sr.ReadLine()) != null)
                {
                    // Add the current line to the list
                    fileData.Add(line);
                }
                // Close the file, because read access is no longer needed
                sr.Close();
            }
        }

        private void UpdateFile(string filePath, List<string> fileData)
        {
            // Create an object to write to file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Loop through each line in file data
                foreach (String str in fileData)
                {
                    // Write the string to the file
                    sw.WriteLine(str);
                }
                // Close access to the file, because we are done writing
                sw.Close();
            }
        }


    }
}
