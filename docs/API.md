# API Documentation for Code Review Agent

## Overview
The Code Review Agent is designed to automate the process of code reviews, ensuring that code adheres to defined standards and guidelines. This document outlines the API endpoints, request/response formats, and usage examples.

## API Endpoints

### 1. Start Review
**Endpoint:** `POST /api/review/start`

#### Request
```json
{
  "repository": "string",
  "branch": "string"
}
```
#### Response
**200 OK**  
```json
{
  "review_id": "string",
  "status": "pending"
}
```

### 2. Get Review Status
**Endpoint:** `GET /api/review/status/{review_id}`

#### Response
**200 OK**  
```json
{
  "review_id": "string",
  "status": "string",
  "comments": [
    {
      "file": "string",
      "comment": "string",
      "severity": "info|warning|error"
    }
  ]
}
```

### 3. Submit Review Comments
**Endpoint:** `POST /api/review/comments`

#### Request
```json
{
  "review_id": "string",
  "comments": [
    {
      "file": "string",
      "comment": "string",
      "severity": "info|warning|error"
    }
  ]
}
```
#### Response
**200 OK**  
```json
{
  "message": "Comments submitted successfully"
}
```

## Usage Example

### Start a Review
```bash
curl -X POST /api/review/start -d '{"repository": "my-repo", "branch": "main"}'
```

### Check Review Status
```bash
curl -X GET /api/review/status/{review_id}
```

### Submit Comments
```bash
curl -X POST /api/review/comments -d '{"review_id": "abc123", "comments": [{"file": "src/app.js", "comment": "Refactor this function.", "severity": "warning"}]}'
```

## Conclusion
The Code Review Agent API provides a structured way to automate code review processes. For more information, please contact the development team.