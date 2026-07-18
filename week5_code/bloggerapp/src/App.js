import React from 'react';
import CourseDetails from './CourseDetails';
import BookDetails from './BookDetails';
import BlogDetails from './BlogDetails';

function App() {
  const showCourse = true;
  const showBook = true;
  const showBlog = true;

  return (
    <div
      style={{
        display: 'flex',
        justifyContent: 'space-around'
      }}
    >
      {showCourse && (
        <div style={{ padding: '20px' }}>
          <CourseDetails />
        </div>
      )}

      {showBook ? (
        <div
          style={{
            padding: '20px',
            borderLeft: '5px solid green'
          }}
        >
          <BookDetails />
        </div>
      ) : null}

      {showBlog && (
        <div
          style={{
            padding: '20px',
            borderLeft: '5px solid green'
          }}
        >
          <BlogDetails />
        </div>
      )}
    </div>
  );
}

export default App;