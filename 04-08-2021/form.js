let students = [];
const addStudent = (ev) =>
{
    ev.preventDefault();
    let student = {
        reg_no : document.getElementById('regno').value,
        first_name : document.getElementById('fname').value,
        last_name : document.getElementById('lname').value,
        email_id : document.getElementById('emailId').value,
        dob : document.getElementById('dob').value
    }

    students.push(student);
    document.querySelector('form').reset();

    //To display the objects in separate div
    let pre = document.querySelector('#content pre');
    pre.textContent = '\n' + JSON.stringify(students,'\t',2);

    localStorage.setItem('StudentDatabase',JSON.stringify(students));
}

document.addEventListener('DOMContentLoaded',() => {
    document.getElementById('submit').addEventListener('click',addStudent);
});