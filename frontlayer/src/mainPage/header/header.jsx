import { HeaderDumb } from './headerDumb'
import React from 'react'
import '../custom.css'

const MainPageHeader = () => {
  return (
        <div className='MainHeader'>
          <a href='#'>
          <div className='headerComponent'>project logo</div>
          </a>
            {HeaderDumb.map((headerTitle, index) => (
              <div key={index} className='headerComponent'><a href='#'>{headerTitle.title}</a></div>
            ))}
            <div className='headerComponent_LoginButton'>
              <a href='#'>
              <button className='headerComponent' style={{ color: 'white', fontWeight: 'bold' }}>login button</button>
              </a>
            </div>
        </div>
  )
}
export default MainPageHeader
