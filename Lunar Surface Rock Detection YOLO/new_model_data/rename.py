# Pythono3 code to rename multiple
# files in a directory or folder

# importing os module
import os

# Function to rename multiple files
def main():
    i = 700

    for filename in os.listdir("E:/Masrur/ROCKS/Rock pics-20191016T082340Z-001/new_model_data/Breccia/"):
        dst =str(i) + ".PNG"
        src ="E:/Masrur/ROCKS/Rock pics-20191016T082340Z-001/new_model_data/Breccia/"+ filename
        dst ="E:/Masrur/ROCKS/Rock pics-20191016T082340Z-001/new_model_data/Breccia/"+ dst

        # rename() function will
        # rename all the files
        os.rename(src, dst)
        i += 1

# Driver Code
if __name__ == '__main__':

    # Calling main() function
    main()
