import os
import shutil
import time

startTime = time.time()

sourceDirectory = "C:/Users/e0498617/source/repos/MSP430_UpdaterV2.0/MSP430_UpdaterV2.0/bin/Debug"
targetDirectory = "S:/Stasa/repos/MSP430_UpdaterV2.0"

#sourceDirectory = "C:/Users/e0498617/source/repos/SystemsMonitor/SystemsMonitor/bin/Debug"
#targetDirectory = "S:/Stasa/SystemsMonitor"


# For all files
#srcFiles = os.listdir(sourceDirectory)

## Only include none .txt files
temp = os.listdir(sourceDirectory)
srcFiles = []
for s in temp:
    if not s.endswith(".txt"):
        srcFiles.append(s)
## end non .txt files

# For select files
#srcFiles = ["ACB_Tool.exe", "ACB_Tool.pdb", "ACB_Tool.exe.config", "StasaLibrary.dll", "StasaLibrary.pdb"]

print("Found {} files to copy.".format(len(srcFiles)))


for fileName in srcFiles:
    fullFileName = os.path.join(sourceDirectory, fileName)
    if os.path.isfile(fullFileName):
        shutil.copy(fullFileName, targetDirectory)
        print("Copied file '{}'".format(fullFileName))
    else:
        print("Failed to copy file '{}'".format(fullFileName))
print("Completed in {}s".format(round(time.time() - startTime, 3)))


