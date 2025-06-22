import React from "react";
import { Link } from "react-router-dom";

export default function Home() {
  return (
    <div className="mx-auto max-w-7xl px-4 sm:px-6 lg:px-8 py-10">
      {/* Hero Section */}
      <div className="relative bg-gray-100 rounded-lg p-6 sm:p-10 flex flex-col-reverse sm:flex-row items-center justify-between">
        {/* Text Content */}
        <div className="text-center sm:text-left sm:w-1/2 space-y-5">
          <h2 className="text-3xl sm:text-4xl font-bold text-gray-800">
            Download Now
            <br />
            <span className="text-orange-700">Discover Awesome Features</span>
          </h2>

          <Link
            to="/"
            className="inline-flex items-center gap-2 px-5 py-2.5 bg-orange-700 text-white rounded-lg hover:bg-orange-800 transition"
          >
            <svg
              fill="white"
              width="20"
              height="20"
              xmlns="http://www.w3.org/2000/svg"
              viewBox="0 0 24 24"
            >
              <path d="M1.571 23.664l10.531-10.501 3.712 3.701-12.519 6.941c-.476.264-1.059.26-1.532-.011l-.192-.13zm9.469-11.56l-10.04 10.011v-20.022l10.04 10.011zm6.274-4.137l4.905 2.719c.482.268.781.77.781 1.314s-.299 1.046-.781 1.314l-5.039 2.793-4.015-4.003 4.149-4.137zm-15.854-7.534c.09-.087.191-.163.303-.227.473-.271 1.056-.275 1.532-.011l12.653 7.015-3.846 3.835-10.642-10.612z" />
            </svg>
            Download Now
          </Link>
        </div>

        {/* Hero Image */}
        <div className="sm:w-1/2 flex justify-center mb-6 sm:mb-0">
          <img
            src="https://cdn-icons-png.flaticon.com/512/5231/5231019.png"
            alt="Illustration 1"
            className="w-40 sm:w-60 lg:w-72 object-contain"
          />
        </div>
      </div>

      {/* Second Image Section */}
      <div className="flex justify-center mt-12">
        <img
          src="https://cdn-icons-png.flaticon.com/512/3135/3135715.png"
          alt="Illustration 2"
          className="w-32 sm:w-48 lg:w-56 object-contain"
        />
      </div>

      {/* Heading */}
      <h1 className="text-center text-2xl sm:text-4xl mt-10 font-semibold text-gray-900">
        Lorem Ipsum Yojo
      </h1>
    </div>
  );
}
