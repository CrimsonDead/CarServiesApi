import { HeaderDumb } from './headerDumb'
import React from 'react'
import '../custom.css'
import { Link } from 'react-router-dom';

const MainPageHeader = () => {
  return (
        <div className='MainHeader'>
          <a href='#'>
          <div className='headerComponent'>project logo</div>
          </a>
            {HeaderDumb.map((headerTitle, index) => (
              <div key={index} className='headerComponent'><a href='#'>{headerTitle.title}</a></div>
            ))}
            <Link to = "/login">
            <div className='headerComponent_LoginButton'>
                <button className='headerComponent' style={{ color: 'white', fontWeight: 'bold' }}>
                  login button
                </button>
              </div>
            </Link>
        </div>
  )
}
export default MainPageHeader
