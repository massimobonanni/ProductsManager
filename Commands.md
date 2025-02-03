# Commands for demo

## Run load test using K6

Add the url to test to the `get` method in the `SimpleLoadTest.js` file and run the following command to start the load test.

```bash
k6 run SimpleLoadTest.js
```

## Attach an existing folder to a GitHub repository

### Step 1: Initialize the Git repository in your existing folder

```bash
cd /path/to/your/existing/folder
git init
```

### Step 2: Add your remote GitHub repository

You'll need the URL of your GitHub repository. It typically looks like this: https://github.com/username/repository.git.

```bash
git remote add origin https://github.com/username/repository.git
```

### Step 3: Add your files to the staging area

```bash
git add .
```

### Step 4: Commit your files

```bash
git commit -m "Initial commit"
```

### Step 5: Push your changes to the GitHub repository

```bash
git push -u origin master
```

If you're using a default branch other than master (like main), replace master with main or the name of your default branch.