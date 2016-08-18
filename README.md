# XnNationalDefenseMobilize

一、工作流程  
1. fork代码到你的远程仓库   地址：https://github.com/Zhengjun-Du/XnNationalDefenseMobilize   
2. clone你的远程仓库到本地仓库  
3. 写项目  
4. 提交到你的本地仓库  
5. 提交到你的远程仓库  
6. 发送pull request 请求 合并  
7. 

二、merge tips:  
Step 1: From your project repository, check out a new branch and test the changes.  

git checkout -b Xiaohong-Lee-master master  
git pull git://github.com/Xiaohong-Lee/testGit.git master  

Step 2: Merge the changes and update on GitHub. 

git checkout master  
git merge --no-ff Xiaohong-Lee-master  
git push origin master
