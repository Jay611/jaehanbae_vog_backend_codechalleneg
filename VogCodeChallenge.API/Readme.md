## GET /
{
    "href": "https://localhost:5001/",
    "employees": {
        "href": "https://localhost:5001/api/employees"
    },
    "employeesByDepartment": {
        "development": "https://localhost:5001/api/employees/department/001",
        "sales": "https://localhost:5001/api/employees/department/002"
    }
}

## GET /api/employees
[
    {
        "id": "301df04d-8679-4b1b-ab92-0a586ae53de1",
        "firstName": "Jaehan",
        "lastName": "Bae",
        "jobTitle": "Developer",
        "address": "72 Confederation Dr., Toronto, Canada",
        "departmentId": "001"
    },
    {
        "id": "ee2b83be-91db-4de5-8122-35a9e91959e2",
        "firstName": "Yuki",
        "lastName": "Kakazu",
        "jobTitle": "Project manager",
        "address": "941 Progress Ave, Toronto, Canada",
        "departmentId": "001"
    },
    {
        "id": "ee2b83be-91db-4de5-8122-35a9e91959e3",
        "firstName": "June",
        "lastName": "Chen",
        "jobTitle": "Sales manager",
        "address": "941 Progress Ave, Toronto, Canada",
        "departmentId": "002"
    }
]

## GET /api/employees/department/001
[
    {
        "id": "301df04d-8679-4b1b-ab92-0a586ae53de1",
        "firstName": "Jaehan",
        "lastName": "Bae",
        "jobTitle": "Developer",
        "address": "72 Confederation Dr., Toronto, Canada",
        "departmentId": "001"
    },
    {
        "id": "ee2b83be-91db-4de5-8122-35a9e91959e2",
        "firstName": "Yuki",
        "lastName": "Kakazu",
        "jobTitle": "Project manager",
        "address": "941 Progress Ave, Toronto, Canada",
        "departmentId": "001"
    }
]
