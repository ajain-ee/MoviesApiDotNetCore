import React from 'react';
import ReactDOM from 'react-dom';
import MovieList from './movieList.jsx';
class App extends React.Component {
     render() {
          return (
               <div>
                    <MovieList url="/api/movies" />
               </div>
          );
     }
}
ReactDOM.render(
     <App />,
     document.getElementById('container')
);

module.hot.accept();