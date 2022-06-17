import React, { useState, useEffect } from 'react';
import '../mainPage/custom.css';
import { LoginPageFields, RegistrationPageFields } from './loginPageDumb';

const Login = ({ isLoginPage }) => {

  const serverRequst = async () => {
    // const body =  
    //   {
    //     UserName: "qweKing",
    //     EMail: "kenzxc@gmail.com",
    //     role: "Client",
    //     password: "SSSr4nk",
    //   }

    // let response = await fetch.post('http://carserviceboard.somee.com/api/Users/Register', { body });
    
    let response = await fetch.post('http://carserviceboard.somee.com/api/Users/Login?password=SSSr4nk&username=zxcKing');
    console.log(response);
    let responseJson = await response.json();
    console.log(responseJson);
  };

  const [LoginPage, setIsLoginPage] = useState(false);

  useEffect(() => {
    // setIsLoginPage(isLoginPage);
    serverRequst();
  }, []);

  const pageFormFields = LoginPage ? LoginPageFields : RegistrationPageFields;

  return (
     <>
      <div className='mainLoginComponent'>
          <div className='loginComponent'>
              <p className='LoginPageMainText'>
                  {LoginPage ? 'Login' : 'Registration'}
              </p>
              <form>
              <div>
              {pageFormFields.map((fields, index) => (
                <div key={index} className='loginFields'>
                    <input type='text' placeholder={fields.field} style={{ borderRadius: '7px', borderColor: 'black', borderWidth: '3px' }} />
                </div>
              ))}
              </div>
                <button className='login_btn'>
                    {LoginPage ? 'LogIn' : 'Registration'}
                </button>
              </form>
          </div>
      </div>
     </>
  )
}
export default Login
