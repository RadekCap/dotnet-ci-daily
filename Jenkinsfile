pipeline {
  agent any
  stages {
    stage('Restore') {
      steps {
        sh 'dotnet restore'
      }
    }
    stage('Clean') {
      steps {
        sh 'dotnet clean'
      }
    }
    stage('Build') {
      steps {
        sh 'dotnet build --configuration Release'
      }
    }
    stage('Run tests') {
      steps {
        sh 'dotnet test --logger "junit;LogFilePath=./results.xml'
      }
    }
  }
}