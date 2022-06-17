import { PROJECT_NAME, PROJECT_DESCRIPTION, MAIN_PAGE_LOGIN_BTN_TEXT, MAIN_PAGE_PROJECT_ADVANTAGES } from './bodyDumb';
import React, { useState } from 'react';
// import React from 'react'
import '../custom.css';

const MainPageBody = () => {
  const [state, setState] = useState(0);
  const onButtonClick = () => {
    setState(state + 1);
  };
  return (
        <div className='MainBodyContainer'>
            <div className='bodyContantContainer'>
                <div>
                <div className='projectName'>
                    {PROJECT_NAME}
                </div>
                <div className='projectDescription' style={{ marginTop: '20px' }}>
                    {PROJECT_DESCRIPTION}
                </div>
                <button className='body_LoginButton'
                    // onClick={setState(state + 1)}
                    >
                    <a href='#'>
                        <div onClick = {onButtonClick} className='projectDescription'
                            style={{ color: 'white', fontWeight: 'bold', padding: '8px', paddingLeft: '8px' }}
                            >
                                {state}
                            {/* {MAIN_PAGE_LOGIN_BTN_TEXT} */}
                        </div>
                    </a>
                </button>
                {/* <div className='projectName'>
                    {state}
                </div> */}
                </div>
            <div className='bodyProjectWrapper'>
            {MAIN_PAGE_PROJECT_ADVANTAGES.map((bodyTexts, index) => (
              <div key={index} className='bodyAdvantagesContent' style={{ fontSize: '10px' }}>
                  <p>
                      <span style={{ fontSize: '15px', fontWeight: 'bold' }}>
                        {bodyTexts.title}
                      </span>
                      <br />
                      <span>
                        {bodyTexts.description}
                      </span>
                  </p>
                  <div></div>
              </div>
            ))}
            </div>
            </div>
        </div>
  )
}
export default MainPageBody
