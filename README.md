# XnNationalDefenseMobilize

merge tips:  
Step 1: From your project repository, check out a new branch and test the changes.  

git checkout -b Xiaohong-Lee-master master  
git pull git://github.com/Xiaohong-Lee/testGit.git master  

Step 2: Merge the changes and update on GitHub. 

git checkout master  
git merge --no-ff Xiaohong-Lee-master  
git push origin master
